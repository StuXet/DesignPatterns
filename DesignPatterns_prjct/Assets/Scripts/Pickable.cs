using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : Interactable
{
    private void OnMouseDown()
    {
        HandleInteraction();
    }
}
