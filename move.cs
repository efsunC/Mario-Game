using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class hareket : MonoBehaviour
{
    private bool facingRight = true;
    private float moveInput;
    private Rigidbody2D rb;
    private bool isGrounded;
    public float jumpForce;
    private int extraJumps;
    public int extraJumpsValue;

    const float hareketgucu = 10;
    bool topluyor=false;
    public GameObject hedef;
    Rigidbody2D myrigidbody2d;
    nesneolustur toplayici;

    private void Start()
    {
        myrigidbody2d = GetComponent<Rigidbody2D>();
        toplayici = Camera.main.GetComponent<nesneolustur>();
    }


    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Elmas")) 
    //    {
    //        Destroy(collision.gameObject); 
    //    }
    //}

    //void DestroyGameObject(Object hedef)
    //{
    //    Destroy(gameObject);
    //}

    //void GitVeTopla()
    //{

    //    if (hedef != null)
    //    {
    //        Vector2 gidilecekyer = new Vector2(hedef.transform.position.x - transform.position.x, hedef.transform.position.y - transform.position.y);
    //        gidilecekyer.Normalize();
    //        myrigidbody2d.AddForce(gidilecekyer * hareketgucu, ForceMode2D.Impulse);
    //    }
    //}
    //private void OnTriggerStay2D(Collider2D other)
    //{
    //   if(other.gameObject==hedef)
    //    {
    //        toplayici.gemYokET(hedef);
    //        myrigidbody2d.velocity = Vector2.zero;
    //        GitVeTopla();
    //    }
    //}

    //void GitVeTopla()
    //{

    //    hedef = toplayici.HedefGem;
    //}




        private void Update()
         {
        Vector3 position = transform.position;
        float yatayinput = Input.GetAxis("Horizontal");
        float dikeyinput = Input.GetAxis("Vertical");
        Jump();


        if (yatayinput != 0)
        {
            position.x += yatayinput * hareketgucu * Time.deltaTime;
        }
        if (dikeyinput != 0) 
        {
            position.y += yatayinput * hareketgucu * Time.deltaTime;
        }
        if (yatayinput > 0)
        {
            
            transform.rotation = Quaternion.Euler(0, 0, 0); 
        }
        else if (yatayinput < 0)
        {
           
            transform.rotation = Quaternion.Euler(0, 180, 0); 
        }
        transform.position = position;
    }
    //void Flip()
    //{
    
    //    facingRight = !facingRight;
    //    Vector3 Scaler = transform.localScale;
    //    Scaler.x *= -1;
    //    transform.localScale = Scaler;
    //}
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 25f), ForceMode2D.Impulse);
        }
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        if (isGrounded == false)
        {
            extraJumps = 0;
        }
    }

}
