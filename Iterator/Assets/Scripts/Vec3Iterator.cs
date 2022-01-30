using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vec3Iterator
{
    public abstract Vector3 MoveNext();
    public abstract Vector3 MoveBack();
    public abstract Vector3 Current();
    public abstract bool HasMore();
    public abstract bool HasLess();
    public abstract void Reset();


  
}
    

