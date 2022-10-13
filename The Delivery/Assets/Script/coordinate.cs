using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coordinate : MonoBehaviour
{
    public GameObject myCube;
    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        LocationLog();
    }

    public void LocationLog(){
        myText.text = "Your Location\n"+ "X : " + myCube.transform.position.x + ","+ "\nY : " + myCube.transform.position.y;
    }
}
