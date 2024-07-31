using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;



public class kameratakip : MonoBehaviour
{
    public float smoothSpeed = 0.125f;
    public Transform player;
    private Vector3 offset;
    void Start()
    {
       offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        {
            if (player != null)
            {
                Vector3 desiredPosition = new Vector3(player.position.x, player.position.y, transform.position.z); 
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); 

                transform.position = smoothedPosition;
            }
        }
    }
    void Update()
    {
        transform.LookAt(player);
    }
}
