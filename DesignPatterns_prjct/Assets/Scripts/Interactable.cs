using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public Player player;
    private List<GameObject> playerInventory;

    [Header("Optional")]
    public GameObject key;



    public virtual void HandleInteraction()
    {
        playerInventory = player.inventory;

        //Objects functionality
    }
   
}
