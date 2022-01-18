using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmmitRay : MonoBehaviour
{
    [Range(0f, 10f)]
    public float range;
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * range;
        Gizmos.DrawRay(transform.position, direction);
    }
}
