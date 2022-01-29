using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeLock : Interactable
{
    public Animator doorAnim;
    public Animator lockAnim;
    bool isClosed = true;


    private void OnMouseDown()
    {
        HandleInteraction();
    }

    public override void HandleInteraction()
    {
        if (isClosed)
        {
            if (player.inventory.Contains(key))
            {
                doorAnim.SetTrigger("Open");
                isClosed = false;
            }
            else
            {
                lockAnim.SetTrigger("Shake");
            }
        }
    }
}
