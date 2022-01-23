using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnob : Interactable
{
    public Room roomToMove;

    public override void HandleInteraction()
    {
        if (key == null)
        {
            player.ChangeRoom(roomToMove);
        }
        else 
        {
            if (player.inventory.Contains(key))
            {
                player.ChangeRoom(roomToMove);
            }
            else
            {
                //**OPTIONAL** play locked animation
            }
        }
    }
}
