using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float minY = -4.5f, maxY = 4.5f;

    public GameObject[] asteroid;
    public GameObject UFO;

    public float timer = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", timer);
    }

    // Update is called once per frame
    void Spawn(){
        float posY = Random.Range(minY, maxY);
        Vector3 temp = transform.position;
        temp.y = posY;

        if (Random.Range(0,2) > 0)
        {
            Instantiate(asteroid[Random.Range(0,asteroid.Length)], temp , Quaternion.identity);
        }else
        {
            Instantiate(UFO, temp , Quaternion.Euler(0f,0f,0f));
        }

        Invoke("Spawn", timer);
    }
}
