using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float speed;
    public AudioClip hit;
    public AudioSource source;
    private float input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * input * speed;
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        source.Play();
    }*/
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            source.Play();
        }

    }
}
