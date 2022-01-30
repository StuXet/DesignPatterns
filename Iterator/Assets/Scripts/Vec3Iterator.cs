using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vec3Iterator
{
    public abstract Vector3 MoveNext(int hop);
    public abstract Vector3 Current();
    public abstract bool HasMore(int hop);
    public abstract void Reset();


  
}
    

