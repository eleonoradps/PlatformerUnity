using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float fallMultiplier = 2.5f; // multiply gravity
    [SerializeField] private float lowJumpMultiplier = 2f; // increase gravity after jump
    [SerializeField] private Rigidbody2D body;

    [SerializeField] Vector2 direction;

    [SerializeField] private float speed = 4;
    [SerializeField] GroundDetection groundDetection;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        body.velocity = new Vector2(direction.x * speed, body.velocity.y);
    }


    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        Debug.Log(body.velocity.x);

        if (Input.GetKeyDown("space") && IsGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, 5);
            Debug.Log("ICI");
        }

        //if (body.velocity.y < 0) // if body's velocity y is less than 0, apply fallMultiplier to gravity
        //{
        //    body.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        //    // minus 1 bc multiply fallMultiplier which is 2.5
        //    // delta time bc gravity is per second and we want this to be a fraction of a second
        //}
        //// else if we're jumping up and !GetButton apply the same thing but instead it's lowJump
        //else if (body.velocity.y > 0 && !Input.GetButton("space"))
        //{
        //    body.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        //}

    }

    private bool IsGrounded()
    {
        return groundDetection.isGrounded;
    }
}
