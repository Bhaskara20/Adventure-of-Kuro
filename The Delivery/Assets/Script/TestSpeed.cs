using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSpeed : MonoBehaviour
{
    public GameObject move;
    public Text Teks;
    //public GameObject movescript;
    // Start is called before the first frame update
    void Start()
    {
        Teks.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        LocationLog();
    }

    public void LocationLog()
    {
        Teks.text = "Your speed\n " + "up : " + VerticalMove.speed + "\ndown : " + VerticalDown.speed + "\nRight : " + HorizontalRight.speed + "\nLeft : " + HorizontalLeft.speed;
    }
}
