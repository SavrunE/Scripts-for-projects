using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControllerForce : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float acceleration;
    [SerializeField] Rigidbody rb;

    private void Start()
    {
        
    }
    private void FixedUpdate()
    {
        rb.AddForce(direction.normalized * acceleration);
    }

}
