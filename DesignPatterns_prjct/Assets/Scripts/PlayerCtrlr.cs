using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrlr : MonoBehaviour
{

    public void LookRight()
    {
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 90f, 0);
    }
    public void LookLeft()
    {
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, -90f, 0);
    }
}
