using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float minY,maxY;
    public float minX,maxX;

    [SerializeField]
    private GameObject playerBullet;

    [SerializeField]
    private Transform BulletSpawnPoint;

    public float attackTimer = 0.35f;
    private float currentAttackTimer;
    private bool canAttack;

    private Animator anim;

    private AudioSource laser;
    // Start is called before the first frame update

    void Awake(){
        anim = GetComponent<Animator>();
        laser = GetComponent<AudioSource>();
    }
    void Start()
    {
        currentAttackTimer = attackTimer;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        shoot();
    }

    void MovePlayer(){
        if (Input.GetAxisRaw("Vertical")>0f)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            if (temp.y > maxY)
            {
                temp.y = maxY;
            }
            transform.position = temp;
        }else if (Input.GetAxisRaw("Vertical")<0f)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;
            if (temp.y < minY)
            {
                temp.y = minY;
            }
            transform.position = temp;
        }
        
        if (Input.GetAxisRaw("Horizontal")>0f)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            if (temp.x > maxX)
            {
                temp.x = maxX;
            }
            transform.position = temp;

        }else if (Input.GetAxisRaw("Horizontal")<0f)
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            if (temp.x < minX)
            {
                temp.x = minX;
            }
            transform.position = temp;
        }
    }

    void shoot(){
        attackTimer += Time.deltaTime;
        if (attackTimer > currentAttackTimer)
        {
            canAttack = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canAttack)
            {
                canAttack = false;
                attackTimer = 0f;
                Instantiate(playerBullet,BulletSpawnPoint.position, Quaternion.identity);
                laser.Play();
            }
            
        }
    }

    void respawn()
    {
        SceneManager.LoadScene("Space");
    }
    void death(){
        gameObject.SetActive(false);
        respawn();
        Invoke("death", 3f);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Bullet" || other.tag == "Enemy")
        {
            Invoke("death", 3f);
            //anim
            anim.Play("death");
            //respawn();
            //anim.Play("death");
        }    
    }
}
