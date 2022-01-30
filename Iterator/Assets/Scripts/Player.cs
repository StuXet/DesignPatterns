using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public Positions positions = new Positions();
    public int stepSize = 1;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = positions.iterator.Current();
        Debug.Log(transform.position);
    }

    public void MoveForward()
    {
        positions.MovePos(stepSize);
        transform.position = positions.iterator.Current();
        Debug.Log(transform.position);
    }

    public void MoveBack()
    {
        positions.MovePos(-stepSize);
        transform.position = positions.iterator.Current();
        Debug.Log(transform.position);
    }

    public void IncreaseStepSize()
    {
        stepSize++;
    }
    public void DecreaseStepSize()
    {
        stepSize--;
    }

    
}
