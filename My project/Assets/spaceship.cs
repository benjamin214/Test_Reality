using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceship : MonoBehaviour
{
    GameObject a;
    Rigidbody2D rb;
    public float speed;
    int health = 3;
    public GameObject bullet;
    int delay = 0;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        a = transform.Find("a").gameObject;
    }


    void Start()
    {
        
    }


    void Update()
    {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0));
        rb.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed));


        if (Input.GetKey(KeyCode.Space) && delay > 60)
        {
            Shoot();

        }
        delay++;
    }

    public void Damage()
    {
        health--;
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }

    void Shoot()
    {
        delay = 0;
        Instantiate(bullet, a.transform.position, Quaternion.identity);

       
    }
}
