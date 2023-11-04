using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    DefenseSelectionMenu defenseSelection;
    Vector2 menuSelectionPosition = new Vector2(0f, 0f);

    void OnMouseDown()
    {

        if (FindObjectOfType<DefenseSelectionMenu>())
        {
            defenseSelection = FindObjectOfType<DefenseSelectionMenu>();
            Destroy(defenseSelection);
        }
        else
        {
            DefenseSelectionMenu newDefenseSelection = Instantiate(defenseSelection, menuSelectionPosition, Quaternion.identity);
        }
    }
}
