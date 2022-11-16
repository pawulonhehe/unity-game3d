using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAB6Z2 : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 targetPosition;
    public List<Vector3> positions = new List<Vector3>();
    public float speed = 2f;
    public bool isMoving;
    
    void Start()
    {
        positions.Add(transform.position);
        positions.Add(startingPosition);
    }

    void Update()
    {
        if (isMoving == true && transform.position == targetPosition)
        {
            isMoving = false;
        }
        if (isMoving == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FPS"))
        {
            other.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("FPS"))
        {
            other.transform.parent = null;
        }
    }
}
