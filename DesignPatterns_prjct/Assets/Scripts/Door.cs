using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    private Room roomA;
    private Room roomB;
    public LayerMask layerMask;
    public float sphereCastRange = 2;

    private void Awake()
    {
        Collider[] rooms =  Physics.OverlapSphere(transform.position, sphereCastRange, layerMask);
        roomA = rooms[0].transform.parent.GetComponent<Room>();
        roomB = rooms[1].transform.parent.GetComponent<Room>();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, sphereCastRange);
    }

    public override void HandleInteraction()
    {
        if (player.currentRoom == roomA)
        {
            player.ChangeRoom(roomB);
        }
        else
        {
            player.ChangeRoom(roomA);
        }
    }
}
