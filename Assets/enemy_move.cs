using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{
    public GameObject bomb;

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "fireball")
        {
        transform.position = transform.position + new Vector3(-.01f,0,0);
        }
        else
        transform.position = transform.position + new Vector3(.001f,0,0);
        
    }

    private void OnTriggerEnter2D(Collider2D arg)
    {
        if(arg.tag == "border" || arg.tag == "fireball")
        {
            Destroy(this.gameObject);
            Destroy(GameObject.FindWithTag("fireball")); 
        }
        if(arg.tag == "fireball")
        {
            Instantiate(bomb, this.gameObject.transform.position, transform.rotation);
            
        }
    }
}
