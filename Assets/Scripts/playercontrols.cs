using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{   
    //Initializing variables
    private Rigidbody2D rb;
    private float move;
    public float speed;
    public float jump;

    
    // Start is called before the first frame update
    void Start()
    {
        //referencing rigidbody so we can work with physics
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        //left and right will choose either 1 or -1
       move = Input.GetAxisRaw("Horizontal");

       //set x axis of velocity to movement
       rb.velocity = new Vector2(move * speed, rb.velocity.y);
   
        //flippsing sprite left and right
        if (move > 0)
        {
            gameObject.transform.localScale = new Vector3(1,1,1);
        }

         if (move < 0)
        {
            gameObject.transform.localScale = new Vector3(-1,1,1);
        }

    }
}