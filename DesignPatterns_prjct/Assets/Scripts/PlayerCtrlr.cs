using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrlr : MonoBehaviour
{
    public List<GameObject> rooms;
    public GameObject currentRoom;
    public List<GameObject> inventory;

    public void SwitchRoom(int roomNum)
    {
        currentRoom = rooms[roomNum];
    }

    private void Update()
    {
        gameObject.transform.position = currentRoom.GetComponent<Room>().centerGO.transform.position;
    }

    public void LookRight()
    {
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 90f, 0);
    }
    public void LookLeft()
    {
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, -90f, 0);
    }
}
