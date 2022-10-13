using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMove : MonoBehaviour
{
    static public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed=0f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.y += speed * Time.deltaTime;
        transform.position = temp;
    }
}
