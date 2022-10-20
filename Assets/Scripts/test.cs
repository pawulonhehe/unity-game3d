using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float DistancePerSecond;
    void Update()
    {
        transform.Translate(0,0, DistancePerSecond * Time.deltaTime);
    }
}
