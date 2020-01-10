using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brick_p3 : MonoBehaviour
{
    
    public Text score_text;
    public Spawner sp;
    public Sprite Sprite_damaged1;
    public Sprite Sprite_damaged2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (durability == 0)
        {

        }
        else if (durability == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Sprite_damaged1;
        }
        else if (durability == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Sprite_damaged2;
        }
    }
    
    int durability = 0;
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (durability == 2)
        {
            Destroy(gameObject);
            FindObjectOfType<Spawner>().RemoveBrick_p3(this);
        }
        else
        {
            durability++;
        }
    }
}