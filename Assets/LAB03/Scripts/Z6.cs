using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z6 : MonoBehaviour
{

    public Transform target;
    public float smoothTime = 0.3f;
    public float Velocity = 0.0f;

    void Update()
    {
        float newPositionX = Mathf.SmoothDamp(transform.position.x, target.position.x, ref Velocity, smoothTime);
        float newPositionZ = Mathf.SmoothDamp(transform.position.z, target.position.z, ref Velocity, smoothTime);
        transform.position = new Vector3(newPositionX, transform.position.y, newPositionZ);
    }
}