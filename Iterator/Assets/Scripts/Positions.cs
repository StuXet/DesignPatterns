using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positions 
{
    private List<Vector3> positions;
    public PosIterator iterator;
    public void Add(Vector3 pos)
    {
        positions.Add(pos);
    }
    public void Remove(int index)
    {
        positions.RemoveAt(index);
    }
    public void Remove(Vector3 pos)
    {
        positions.Remove(pos);
    }
    public void MovePos(int moveStep)
    {
        iterator.MoveNext(moveStep);
    }

    public Positions()
    {
        positions = new List<Vector3>();    
        iterator = new PosIterator(positions);
    }
    
    public Positions(List<Vector3> _positions)
    {
        positions = _positions;    
        iterator = new PosIterator(positions);
    }
    


}
