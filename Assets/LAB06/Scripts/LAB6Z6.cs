using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAB6Z6 : MonoBehaviour
{
    
     private void OnTriggerEnter(Collider other)
        {
        if (other.gameObject.CompareTag("FPS"))
            {
                Debug.Log("Player dotknal przeszkody.");
            } 
        }
}
