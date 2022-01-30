using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosIterator : Vec3Iterator 
{
    private List<Vector3> positions;
    private int currentIndex;

    public override Vector3 Current()
    {
        return positions[currentIndex];
    }

    public override bool HasLess()
    {
        if (currentIndex - 1 < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override bool HasMore()
    {
        if (currentIndex + 1 >= positions.Count)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override Vector3 MoveNext()
    {
        if (HasMore())
        {
            currentIndex ++;
            return positions[currentIndex];
        }
        else
        {
            currentIndex = 0;
            return positions[currentIndex];
        }
    }

    public override Vector3 MoveBack()
    {
        if (HasLess())
        {
            currentIndex--;
            return positions[currentIndex];
        }
        else
        {
            currentIndex = positions.Count -1;
            return positions[currentIndex];
        }
    }

    public override void Reset()
    {
        currentIndex = 0;
    }
    public PosIterator(List<Vector3> _pos)
    {
        positions = _pos;
    }
}
