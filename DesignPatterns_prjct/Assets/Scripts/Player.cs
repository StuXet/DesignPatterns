using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> inventory;
    public List<Transform> positions;
    public Room currentRoom;
    [Tooltip("List of positions the player can move to in each specific room")]
    int camPosCounter;

    private static Player _instance;
    public static Player Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        positions = currentRoom.playerPos;
        transform.position = positions[0].position;
        transform.rotation = positions[0].rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeRoom(Room nextRoom)
    {
        camPosCounter = 0;
        currentRoom = nextRoom;
        positions = nextRoom.playerPos;
        transform.position = positions[camPosCounter].position;
        transform.rotation = positions[camPosCounter].rotation;
    }

    public void NextPos()
    {
        camPosCounter++;
        if (camPosCounter + 1 > positions.Count)
        {
            camPosCounter = 0;
        }
        transform.position = positions[camPosCounter].position;
        transform.rotation = positions[camPosCounter].rotation;
    }

    public void PreviousPos()
    {
        camPosCounter--;
        if (camPosCounter < 0)
        {
            camPosCounter = positions.Count - 1;
        }
        transform.position = positions[camPosCounter].position;
        transform.rotation = positions[camPosCounter].rotation;
    }
}
