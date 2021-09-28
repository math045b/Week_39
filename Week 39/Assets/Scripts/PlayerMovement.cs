using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float runSpeed = 4.0f;
    public float turnSpeed = 1.0f;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, -10); 
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.AddTorque(horizontal * turnSpeed);
        body.AddRelativeForce(new Vector2(0, vertical * runSpeed));
    }
}
