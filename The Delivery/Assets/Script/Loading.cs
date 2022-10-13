using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    //public string scene;

    private void Start()
    {
        StartCoroutine(tunggu());
    }
    IEnumerator tunggu()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
