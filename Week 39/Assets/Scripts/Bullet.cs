using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    GameManager manager;

    public float speed = 30;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddRelativeForce(new Vector2(0, speed));
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.tag == "Enemy")
        {
            manager.addScore(collision.gameObject.GetComponent<Enemy>().killScore);
            Destroy(collision.gameObject);
        }
    }
}
