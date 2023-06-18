using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInvetory : MonoBehaviour
{
    public void onClick()
    {
        if (GameObject.FindGameObjectWithTag("ShowInventory").GetComponent<CanvasGroup>().alpha == 1.0f)
            GameObject.FindGameObjectWithTag("ShowInventory").GetComponent<CanvasGroup>().alpha = 0f;
        else GameObject.FindGameObjectWithTag("ShowInventory").GetComponent<CanvasGroup>().alpha = 1.0f;
    }
 
}
