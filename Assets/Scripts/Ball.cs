using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rigidbody;
    public AudioClip hit;
    public AudioClip hitplat;
    public AudioSource source;
    public Collider2D platform_collider;
    public Collider2D wall_collider;
    public Collider2D wall_collider2;
    public Collider2D wall_collider3;
    // Start is called before the first frame update
    void Start()
    {
        Respawn();
        source.clip = hit;
        source.clip = hitplat;
    }

    // Update is called once per frame
    void Update()
    {
        Unbug();
        rigidbody.velocity = rigidbody.velocity.normalized * speed;
    }

    
    /*public void OnCollisionEnter2D(Collision2D collision)
    {
        speed = 5;
    }*/
    public void Unbug()
    {
        if(Input.GetKeyDown("space"))
        {
            Respawn();
        }
    }
    public void Respawn()
    {
        transform.position = Vector3.zero;
        //GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
        //GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
        //System.Random randomx = new System.Random();
        //Random randomy = new Random();
        
        //rigidbody.velocity = new Vector2(randomx , randomy) * speed;
        rigidbody.velocity = UnityEngine.Random.insideUnitCircle.normalized * speed;
    }
    int score = 0;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == platform_collider)
        {
            source.PlayOneShot(hitplat);
        }
        else if(collision.collider == wall_collider || collision.collider == wall_collider2 || collision.collider == wall_collider3)
        {

        }
        else
        {
            source.PlayOneShot(hit);
            score++;
            UI_Manager.instance.score_text.text = "Score :" + score;
        }
    }

}
