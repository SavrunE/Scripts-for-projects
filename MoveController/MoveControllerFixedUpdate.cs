using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControllerFixedUpdate : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed = 0.05f;


    void Start()
    {

    }
    
    void FixedUpdate()
    {
        transform.Translate(direction.normalized * speed);
    }
}
