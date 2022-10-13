using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoController : MonoBehaviour
{
    private float counter;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move(){
        if (Input.GetAxisRaw("Vertical") > 0f)
        {
            VerticalMove.speed = VerticalMove.speed + 5f * Time.deltaTime;
            VerticalDown.speed = VerticalDown.speed - 5f * Time.deltaTime;
        }
        else if (Input.GetAxisRaw("Vertical") < 0f)
        {
            VerticalDown.speed = VerticalDown.speed + 5f * Time.deltaTime; ;
            VerticalMove.speed = VerticalMove.speed - 5f * Time.deltaTime; ;
            //GetComponent<VerticalDown>().enabled = true;
        }

        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            HorizontalRight.speed = HorizontalRight.speed+5f * Time.deltaTime;
            HorizontalLeft.speed = HorizontalLeft.speed - 5f * Time.deltaTime;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            HorizontalLeft.speed = HorizontalLeft.speed+5f * Time.deltaTime;
            HorizontalRight.speed = HorizontalRight.speed - 5f * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            brake();
        }
    }

    void brake()
    {
        VerticalMove.speed = 0f;
        VerticalDown.speed = 0f;
        HorizontalLeft.speed = 0f;
        HorizontalRight.speed = 0f;
    }
}
