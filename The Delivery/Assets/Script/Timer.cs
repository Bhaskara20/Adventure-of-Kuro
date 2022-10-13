using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 0f;
    [SerializeField] Text counter;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        counter.text = currentTime.ToString("0");
        if (counter.text == "60")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


    }
}
