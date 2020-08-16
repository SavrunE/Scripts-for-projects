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
    //"Писать код в апдейте не лучая идея", тк не стабильно.
    void FixedUpdate()
    {
        transform.Translate(direction.normalized * speed);
    }
}
