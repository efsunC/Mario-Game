using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nesneolustur : MonoBehaviour
{
   [SerializeField]
    public  GameObject gemprefab;
    //List<GameObject> gems = new List<GameObject>();

    public GameObject HedefGem
    {
        get
        {
            return gemprefab;
        }
    }
    private void Update()
    {
        
        if (Input.GetMouseButtonUp(1))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            Vector3 oyunDunyasıPozisyon= Camera.main.ScreenToWorldPoint(position);
            gemprefab=Instantiate(gemprefab, oyunDunyasıPozisyon, Quaternion.identity);
            
   
        }
    }

    public void gemYokET(GameObject yokedilecekgem)
    {

        GameObject.Destroy(yokedilecekgem);
    }
    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Oyuncu")) 
    //    {
    //        Destroy(gameObject); 
    //    }
    //}
}


