using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaskontrol : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); 
        }
    }
}
