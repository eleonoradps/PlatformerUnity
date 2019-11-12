using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float fallMultiplier = 2.5f; // multiply gravity
    [SerializeField] private float lowJumpMultiplier = 2f; // increase gravity after jump

    // reference to rigidbody2D
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    
    void Update() // check every frame
    {
        // if rb's velocity y is less than 0, apply fallMultiplier to gravity
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            // minus 1 bc multiply fallMultiplier which is 2.5
            // delta time bc gravity is per second and we want this to be a fraction of a second
        }
        // else if we're jumping up and !GetButton apply the same thing but instead it's lowJump
        else if(rb.velocity.y > 0 && !Input.GetButton("space"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
}
