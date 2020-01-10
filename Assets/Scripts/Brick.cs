using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brick : MonoBehaviour
{
    //public GameObject pomoc;
    public Text score_text;
    public Spawner sp;
    

    // Start is called before the first frame update
    void Start()
    {
        //sp = GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        //sp = GetComponent<Spawner>();
    }
    int score = 0;
    int durability = 0;
    int pomocna = FindObjectOfType<Spawner>().pomocna;
    //int pomocna = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        
        //score++;
        Destroy(gameObject);
        FindObjectOfType<Spawner>().RemoveBrick(this);
        /*if (pomocna == 0)
        {
            Destroy(gameObject);
            FindObjectOfType<Spawner>().RemoveBrick(this);
        }

        else if(pomocna == 1 && durability == 1)
        {
            Destroy(gameObject);
            FindObjectOfType<Spawner>().RemoveBrick(this);
            durability = 0;
        }
        else if(sp.pomocna == 1 &&durability < 1)
        {
            durability++;
        }
        
        else if(sp.pomocna == 2 && durability == 2)
        {
            Destroy(gameObject);
            FindObjectOfType<Spawner>().RemoveBrick(this);
            durability = 0;
        }
        else if (sp.pomocna == 2 && durability < 2)
        {
            durability++;
        }

        else if (sp.pomocna == 3 && durability == 3)
        {
            Destroy(gameObject);
            FindObjectOfType<Spawner>().RemoveBrick(this);
            durability = 0;
        }
        else if (sp.pomocna == 3 && durability < 3)
        {
            durability++;
        }*/

        //FindObjectOfType<Spawner>().RemoveBrick(this);
    }
}
