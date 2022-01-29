using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : Interactable
{
    public Animator anim;
    public GameObject knife;
    bool isShaked = false;

    private void OnMouseDown()
    {
        HandleInteraction();    
    }

    public override void HandleInteraction()
    {
        if (!isShaked)
        {
            anim.SetTrigger("Shake");
            knife.GetComponent<Rigidbody>().useGravity = true;
            isShaked = true;
        }
    }
}
