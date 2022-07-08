using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    Rigidbody2D rb;
    int dir = 1;


    void ChangeDirection()
    {
        dir *= -1;

    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.velocity = new Vector2(0, 5 * dir);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (dir == 1)
        {
            if (collision.gameObject.tag == "Ennemies")
            {
                collision.gameObject.GetComponent<Ennemy>().Damage();
                Destroy(gameObject);
            }

        }
        else
        {
            if (collision.gameObject.tag == "Players")
            {
                collision.gameObject.GetComponent<spaceship>().Damage();
                Destroy(gameObject);
            }
        }

    }
}
