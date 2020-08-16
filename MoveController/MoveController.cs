using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private Vector3 direction;

    void Start()
    {
        
    }
    //"Писать код в апдейте не лучая идея", тк не стабильно.
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
    }
}
