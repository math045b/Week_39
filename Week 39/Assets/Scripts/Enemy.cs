using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    GameManager manager;
    GameObject player;

    public int damage = 1;
    public float speed = 5;
    public int killScore = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.AddRelativeForce(new Vector2(0, speed*4));
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        Vector2 currentDir = rb.velocity.normalized;
        Vector2 targetDir2 = (currentDir - new Vector2(player.transform.position.x, player.transform.position.y)).normalized;
        Vector2 targetDir = (transform.position - player.transform.position).normalized;
        float torque = Vector2.Angle(currentDir, Vector2.right) - Vector2.Angle(targetDir, Vector2.right);
        rb.AddTorque(torque*0.01f);
        
        //Vector3 dir = player.transform.position - transform.position;
        //float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //rb.AddTorque(-angle*0.001f);
        //transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        rb.AddRelativeForce(new Vector2(0, speed));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            manager.damagePlayer(damage);
            Destroy(gameObject);
        } else if (collision.gameObject.tag != "Enemy") {
            Destroy(gameObject);
        }
    }
}
