using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject key;
    public GameObject player;
    PlayerCtrlr playerCtrlr;
    

    private void Start()
    {
        playerCtrlr = player.GetComponent<PlayerCtrlr>(); 
    }


    private void OnMouseDown()
    {
        if (playerCtrlr.inventory.Contains(key)) 
        {
            if (playerCtrlr.currentRoom.name == "BrownRoom" && player.transform.eulerAngles.y == 90)
            {
                playerCtrlr.SwitchRoom(2);
                Debug.Log("moved to red room");
            }
            else if (playerCtrlr.currentRoom.name == "BrownRoom" && player.transform.eulerAngles.y == -180f)
            {
                playerCtrlr.SwitchRoom(1);
                Debug.Log("moved to green room");
            }
            else if (playerCtrlr.currentRoom.name == "GreenRoom")
            {
                playerCtrlr.SwitchRoom(0);
                Debug.Log("moved to brown room");
            }
            else if (playerCtrlr.currentRoom.name == "RedRoom")
            {
                playerCtrlr.SwitchRoom(0);
                Debug.Log("moved to brown room");
            }


            //gameObject.transform.eulerAngles = gameObject.transform.eulerAngles + new Vector3(0, 25, 0);
        }
        
    }
}
