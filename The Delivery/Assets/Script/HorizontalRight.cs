using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalRight : MonoBehaviour
{
    static public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }
}
