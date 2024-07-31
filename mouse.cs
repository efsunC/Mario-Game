using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class fare : MonoBehaviour
{
    
    public float hareketMesafesi = 2.0f; 
    public float hareketHizi = 1.0f;   
    private Vector3 baslangicPozisyonu;
    private bool sagaHareketEdiyor = true;


    void Start()
    {
        baslangicPozisyonu = transform.position;
    }

    void Update()
    {
        float yatayHareket = sagaHareketEdiyor ? hareketHizi : -hareketHizi;
        transform.Translate(new Vector3(yatayHareket * Time.deltaTime, 0, 0));

        if (Mathf.Abs(transform.position.x - baslangicPozisyonu.x) >= hareketMesafesi)
        {
            sagaHareketEdiyor = !sagaHareketEdiyor;
        }
    }
    

}
