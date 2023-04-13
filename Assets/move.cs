using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float player_speed;
    private Rigidbody2D rb;
    public GameObject fireball;
    public GameObject firepoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
 
        rb.velocity = new Vector2 (moveHorizontal*player_speed, moveVertical*player_speed);

        if (Input.GetKeyUp(KeyCode.L))
        {
            Instantiate(fireball, firepoint.transform.position, transform.rotation);
        }
        Destroy(GameObject.FindWithTag("bomb"),1);
        
        // if(count>1)
        // {
        //     count=0;
        //     Destroy(GameObject.FindWithTag("bomb"),1);
        // }
        // count++;
        // Debug.Log(count);
    }
    public void move_up()
    {
        transform.position = transform.position + new Vector3(0,.1f,0);
    }
    public void move_down()
    {
        transform.position = transform.position - new Vector3(0,.1f,0);
    }
    public void shooot()
    {
        Instantiate(fireball, firepoint.transform.position, transform.rotation);
    }
}
