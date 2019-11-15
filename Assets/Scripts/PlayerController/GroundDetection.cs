using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetection : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    [SerializeField] public bool isGrounded;

    private void OnTriggerStay2D(Collider2D collider)
    {
        isGrounded = collider != null;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        isGrounded = false;
    }
}
