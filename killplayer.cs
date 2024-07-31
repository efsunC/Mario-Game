using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class oyuncuoldur : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            
            Collider2D collider = GetComponent<Collider2D>();
            Renderer renderer = GetComponent<Renderer>();

            if (collider != null)
            {
                collider.enabled = false;
            }

            if (renderer != null)
            {
                renderer.enabled = false;
            }
            Debug.Log("Nesne yok edildi!");
        
            Destroy(gameObject);
        }
    }
}

