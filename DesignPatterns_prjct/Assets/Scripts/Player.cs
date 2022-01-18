using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Controller Settings")]
    public GameObject currentRoom;
    [Tooltip("List of positions the player can move to in each specific room")]
    public List<Transform> positions;
    int angleCounter;

    [Header("Items settings")]
    public List<GameObject> inventory;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = positions[0].position;
        transform.rotation = positions[0].rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeRoom(GameObject nextRoom)
    {
        angleCounter = 0;
        currentRoom = nextRoom;
        positions = nextRoom.GetComponent<Room>().playerPos;
        transform.position = positions[angleCounter].position;
        transform.rotation = positions[angleCounter].rotation;
    }

    public void NextAngle()
    {
        angleCounter++;
        if (angleCounter + 1 > positions.Count)
        {
            angleCounter = 0;
        }
        transform.position = positions[angleCounter].position;
        transform.rotation = positions[angleCounter].rotation;
    }

    public void PreviousRoom()
    {
        angleCounter--;
        if (angleCounter < 0)
        {
            angleCounter = positions.Count - 1;
        }
        transform.position = positions[angleCounter].position;
        transform.rotation = positions[angleCounter].rotation;
    }
}
