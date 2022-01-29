using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : Interactable
{
    public Animator DrawerAnim;
    bool isClosed = true;

    private void OnMouseDown()
    {
        if (isClosed)
        {
            DrawerAnim.SetTrigger("Open");
            isClosed = false;
        }
    }

}
