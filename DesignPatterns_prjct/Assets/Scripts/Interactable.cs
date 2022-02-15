using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    protected Player player = Player.Instance;


    public GameObject key;

    
    public virtual void HandleInteraction()
    {
        //Objects functionality
    }
   
}
