using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    EnemySpawner myLaneSpawner;

    void Start()
    {
        SetLaneSpawner();
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("Attacker is in lane");
            //Change animation to shooting
        }
        else
        {
            Debug.Log("Nothing here for now");
            //Change animation to idle
        }
    }

    private void SetLaneSpawner()
    {
        EnemySpawner[] enemySpawners = FindObjectsOfType<EnemySpawner>();

        foreach (EnemySpawner enemySpawner in enemySpawners)
        {
            bool isCloseEnough = (Mathf.Abs(enemySpawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                myLaneSpawner = enemySpawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else { return true; }
    }

    public void Shoot()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }


}
