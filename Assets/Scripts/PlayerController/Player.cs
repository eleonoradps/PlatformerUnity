using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;

    [SerializeField] Vector2 direction;

    [SerializeField] private float speed = 4;
    
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
        
        if(Input.GetKeyDown("space"))
        {
            body.velocity = new Vector2(1, 5);
        }

    }
}
