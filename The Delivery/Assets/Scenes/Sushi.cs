using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameObject.SetActive(false);
            audioSource.Play();
            //anim.Play("death");
        }
    }
}
