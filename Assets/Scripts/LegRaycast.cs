using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegRaycast : MonoBehaviour
{
    private RaycastHit hit;
    private Transform transform;

    public Vector3 Position => hit.point;
    public Vector3 Normal => hit.normal;

    private void Awake()
    {
        transform = base.transform;
    }

    private void Update()
    {
        var ray = new Ray(transform.position, -transform.up);
        Physics.Raycast(ray, out hit);
    }
}
