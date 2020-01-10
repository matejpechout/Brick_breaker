using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int rows;
    public int columns;
    public float space;
    public GameObject brickPrefab_p1;
    public GameObject brickPrefab_p2;
    public GameObject brickPrefab_p3;
    public GameObject brickPrefab_p4;
    public GameObject brickPrefab_mz;
    public AudioSource source;
    public AudioClip gamefinished;
    /*public AudioClip hit;
    public AudioSource source;*/
    public Spawner spawner;

    private List<GameObject> bricks = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        source.clip = gamefinished;
        ResetLevel();
        UI_Manager.instance.score_text.text = "Score :" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetLevel()
    {
        foreach(GameObject brick in bricks)
        {
            Destroy(brick);
        }
        bricks.Clear();

        for(int i = 0; i < columns; i++)
        {
            for(int j = 0; j < rows; j++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(i * (brickPrefab_p1.transform.localScale.x + space), -j * (brickPrefab_p1.transform.localScale.y + space));
                GameObject brick = Instantiate(brickPrefab_p1, spawnPos, Quaternion.identity);
                bricks.Add(brick);
            }
        }
    }
    public void NextLevel_p2()
    {
        foreach (GameObject brick in bricks)
        {
            Destroy(brick);
        }
        bricks.Clear();

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(i * (brickPrefab_p2.transform.localScale.x + space), -j * (brickPrefab_p2.transform.localScale.y + space));
                GameObject brick = Instantiate(brickPrefab_p2, spawnPos, Quaternion.identity);
                bricks.Add(brick);
            }
        }
    }
    public void NextLevel_p3()
    {
        foreach (GameObject brick in bricks)
        {
            Destroy(brick);
        }
        bricks.Clear();

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(i * (brickPrefab_p3.transform.localScale.x + space), -j * (brickPrefab_p3.transform.localScale.y + space));
                GameObject brick = Instantiate(brickPrefab_p3, spawnPos, Quaternion.identity);
                bricks.Add(brick);
            }
        }
    }
    public void NextLevel_p4()
    {
        foreach (GameObject brick in bricks)
        {
            Destroy(brick);
        }
        bricks.Clear();

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(i * (brickPrefab_p4.transform.localScale.x + space), -j * (brickPrefab_p4.transform.localScale.y + space));
                GameObject brick = Instantiate(brickPrefab_p4, spawnPos, Quaternion.identity);
                bricks.Add(brick);
            }
        }
    }
    public void NextLevel_mz()
    {
        foreach (GameObject brick in bricks)
        {
            Destroy(brick);
        }
        bricks.Clear();

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(i * (brickPrefab_mz.transform.localScale.x + space), -j * (brickPrefab_mz.transform.localScale.y + space));
                GameObject brick = Instantiate(brickPrefab_mz, spawnPos, Quaternion.identity);
                bricks.Add(brick);
            }
        }
    }
    public int pomocna = 0;
    int score = 0;
    public void RemoveBrick_mz(Brick_mz brick)
    {
        bricks.Remove(brick.gameObject);


        if (bricks.Count == 0)
        {
            source.Play();
            UI_Manager.instance.gamefinished.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void RemoveBrick_p4(Brick_p4 brick)
    {
        //source.Play();

        score++;
        //UI_Manager.instance.score_text.text = "Score :" + score;
        bricks.Remove(brick.gameObject);
        if (bricks.Count == 0)
        {
            NextLevel_mz();
            
        }
    }
    public void RemoveBrick_p3(Brick_p3 brick)
    {
        //source.Play();

        score++;
        //UI_Manager.instance.score_text.text = "Score :" + score;
        bricks.Remove(brick.gameObject);
        if (bricks.Count == 0)
        {
            NextLevel_p4();
            
        }
    }
    public void RemoveBrick_p2(Brick_p2 brick)
    {
        //source.Play();

        score++;
        //UI_Manager.instance.score_text.text = "Score :" + score;
        bricks.Remove(brick.gameObject);
        if (bricks.Count == 0)
        {
            NextLevel_p3();
            
        }
    }
    public void RemoveBrick(Brick brick)
    {
        //source.Play();
        
        score++;
        //UI_Manager.instance.score_text.text = "Score :" + score;
        bricks.Remove(brick.gameObject);
        if (bricks.Count == 0)
        {
            NextLevel_p2();
            
        }
        /*else if (bricks.Count == 0 && pomocna == 1)
        {
            NextLevel_p3();
            pomocna++;
        }
        else if (bricks.Count == 0 && pomocna == 2)
        {
            NextLevel_p4();
            pomocna++;
        }
        else if (bricks.Count == 0 && pomocna == 3)
        {
            NextLevel_mz();
            pomocna++;
        }*/
    }
}
