using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nesnesil : MonoBehaviour
{
    public GameObject gem;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Oyuncu")) 
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
