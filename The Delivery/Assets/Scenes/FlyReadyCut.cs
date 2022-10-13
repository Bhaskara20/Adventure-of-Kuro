using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyReadyCut : MonoBehaviour
{
    public GameObject UI;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            /*if (Input.GetKeyDown(KeyCode.K))
            {
                SceneManager.LoadScene("Space");
            }*/

            //SceneManager.LoadScene("BanditCutscene");
            UI.SetActive(true);



        }
    }

    public void fly()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
