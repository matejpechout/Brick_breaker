using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    public AudioClip hit;
    public AudioClip gameover;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        UI_Manager.instance.lives_text.text = "Lives : " + pomocna;
        source.clip = hit;
        source.clip = gameover;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int pomocna = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        pomocna--;
        source.PlayOneShot(hit);
        
        UI_Manager.instance.lives_text.text = "Lives : " + pomocna;
        if (pomocna == 0)
        {
            source.PlayOneShot(gameover);
            
            UI_Manager.instance.gameover.SetActive(true);
            Time.timeScale = 0;
            FindObjectOfType<Spawner>().ResetLevel();
            pomocna = 3;
        }
        collision.GetComponent<Ball>().Respawn();
        
        
    }
}
