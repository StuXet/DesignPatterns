using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public GameObject key;
    public Player player;
    private List<GameObject> playerInventory;

    public virtual void HandleInteraction()
    {
        playerInventory = player.inventory;

        //Objects functionality
    }
   
}
