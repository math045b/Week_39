using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    GameManager manager;

    public int damage = 1;
    public float speed = 300;
    public int killScore = 100;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddRelativeForce(new Vector2(0, speed));
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            manager.damagePlayer(damage);
        } else if (collision.gameObject.tag != "Enemy") {
            Destroy(gameObject);
        }
    }
}
