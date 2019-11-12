using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : MonoBehaviour
{
    [SerializeField] private float speed = 4;
    [SerializeField] private bool wallJumping;
    [SerializeField] private float targetVelocity;
    [SerializeField] private float move;
    [SerializeField] private bool grounded;
    [SerializeField] private float wallJumpMove;
    [SerializeField] private float maxSpeed = 3.5f;
    [SerializeField] private float maxAirSpeed = 3f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if(grounded)
        {
            targetVelocity = move * maxSpeed;
        }
        else if(wallJumping)
        {
            targetVelocity = wallJumpMove * maxAirSpeed;
        }
        else
        {
            targetVelocity = move * maxAirSpeed;
        }
    }

    void Update()
    {
        
    }
}
