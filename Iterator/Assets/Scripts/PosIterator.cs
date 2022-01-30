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

    public override bool HasMore(int hop)
    {
        if (positions[currentIndex + hop] != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override Vector3 MoveNext(int hop)
    {
        if (HasMore(hop))
        {
            currentIndex += hop;
        }
        else
        {
            currentIndex = (currentIndex + hop) % (positions.Count - 1);
        }
        return positions[currentIndex];
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
