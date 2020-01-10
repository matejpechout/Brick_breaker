using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brick_p2 : MonoBehaviour
{
    
    public Text score_text;
    public Spawner sp;
    public Sprite Sprite_damaged;

    


    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if(durability == 0)
        {

        }
        else if(durability == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Sprite_damaged;
        }
        
    }
    int durability = 0;
    
    //int pomocna = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (durability == 1)
        {
            Destroy(gameObject);
            FindObjectOfType<Spawner>().RemoveBrick_p2(this);
        }
        else
        {
           
            durability++;
        }
        
    }
}
