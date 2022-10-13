using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public float rotateSpeed = 50f;

    public bool canShoot;
    public bool canRotate;
    public bool canMove = true;

    public float boundX = -11f;

    public Transform attackPoint;
    public GameObject bulletPrefb;

    private Animator anim;
    private AudioSource explosionSound;
    // Start is called before the first frame update
    void Awake() {
        anim = GetComponent<Animator>();
        explosionSound = GetComponent<AudioSource>();
    }

    void Start() {
        if (canRotate)
        {
            if (Random.Range(0,2) > 0)
            {
                rotateSpeed = Random.Range(rotateSpeed, rotateSpeed + 20f);
                rotateSpeed *= -1f;
            }
        }

        if (canShoot)
        {
            Invoke("StartShooting",Random.Range(1f,3f));
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    void Move(){
        if (canMove)
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;

            if (temp.x < boundX)
            {
                gameObject.SetActive(false);
            }
        }
    }

    void Rotate(){
        if (canRotate)
        {
            transform.Rotate(new Vector3(0F, 0F, rotateSpeed * Time.deltaTime), Space.World);
        }
    }

    void StartShooting(){
        GameObject bullet = Instantiate(bulletPrefb, attackPoint.position, Quaternion.identity);
        bullet.GetComponent<Bullet>().isEnemyBullet = true;

        if (canShoot)
        {
            Invoke("StartShooting",Random.Range(1f,3f));
        }
    }

    void death(){
        gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "PlayerBullet")
        {
            canMove = false;
            if (canShoot)
            {
                canShoot = false;
                CancelInvoke("StartShooting");
            }
            Invoke("death", 1f);
            //anim
            anim.Play("death");
            explosionSound.Play();
        }    
    }
}
