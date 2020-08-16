using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControllerImpuls : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float acceleration;
    [SerializeField] Rigidbody rb;

    private void Start()
    {
        
    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        rb.AddForce(direction.normalized * acceleration, ForceMode.Impulse);
    }

}
