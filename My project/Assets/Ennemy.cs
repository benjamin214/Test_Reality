using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    public bool canShoot;
    public float fireRate;
    public float health;

    public float xSpeed;
    public float ySpeed;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Start()
    {

    }

    void Update()
    {
        rb.velocity = new Vector2(xSpeed, ySpeed*-1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Players")
        {
            collision.gameObject.GetComponent<spaceship>().Damage();
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
    public void Damage()
    {
        health--;
        if (health == 0)
        {
            Die();
        }
    }
}
