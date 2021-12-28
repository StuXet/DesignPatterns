using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public PlayerCtrlr player; 
    private void OnMouseDown()
    {
        player.inventory.Add(gameObject);
        gameObject.SetActive(false);
        Debug.Log("Collected " + gameObject.name);
    }
}
