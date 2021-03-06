using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnob : Interactable
{
    Door door;
    public Animator anim;

    private void Awake()
    {
        door = transform.parent.GetComponent<Door>();
    }
    private void OnMouseDown()
    {
            if (player.inventory.Contains(door.key) || door.key == null)
            {
                door.HandleInteraction();
            }
            else
            {
                anim.SetTrigger("Shake");
            }
    }
}
