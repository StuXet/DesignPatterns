using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuitCase : Interactable
{
    public GameObject closedSC;
    public GameObject openedSC;
    bool isClosed = true;

    private void OnMouseDown()
    {
        HandleInteraction();
    }

    public override void HandleInteraction()
    {
        if (isClosed)
        {
            closedSC.SetActive(false);
            openedSC.SetActive(true);
            isClosed = false;
        }
    }
}
