using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public Positions positions = new Positions();
    // Start is called before the first frame update
    void Start()
    {
        positions.Add(new Vector3(0, 1, 0));
        positions.Add(new Vector3(1, 1, 0));
        positions.Add(new Vector3(2, 1, 0));
        positions.Add(new Vector3(3, 1, 0));
        positions.Add(new Vector3(4, 1, 0));
        positions.Add(new Vector3(5, 1, 0));
        positions.Add(new Vector3(-5, 1, 0));
        positions.Add(new Vector3(-4, 1, 0));
        positions.Add(new Vector3(-3, 1, 0));
        positions.Add(new Vector3(-2, 1, 0));
        positions.Add(new Vector3(-1, 1, 0));
       
        transform.position = positions.iterator.Current();
        Debug.Log(transform.position);
    }

    public void MoveForward()
    {
        positions.MovePos("Next");
        transform.position = positions.iterator.Current();
        Debug.Log(transform.position);
    }

    public void MoveBack()
    {
        positions.MovePos("Back");
        transform.position = positions.iterator.Current();
        Debug.Log(transform.position);
    }

}
