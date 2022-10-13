using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private Vector2 moveDirect;

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");



        moveDirect = new Vector2(moveX, moveY);
    }


    void Move()
    {
        rb.velocity = new Vector2(moveDirect.x * speed, moveDirect.y * speed);

        if (moveDirect.x < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }else if(moveDirect.x > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
    }

   

}
