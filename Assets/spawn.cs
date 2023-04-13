using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject enemy;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    float time = 10f;
    float spawntime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spawntime > time)
        {
            enemy_spawn();
            spawntime=0;
        }
        spawntime+=.01f;
        // Debug.Log(spawntime);
        // Debug.Log(time);
    }

    void enemy_spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(enemy, transform.position + new Vector3(randomX, randomY,0), transform.rotation);
    }
}
