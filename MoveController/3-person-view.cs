using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public float Speed
    {
        get { return speed; }
        set 
        {
            speed = value;
            if (speed < 0)
                speed = 0;
        }
    }
        private void FixedUpdate()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float forwardAxis = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalAxis,0, forwardAxis) * speed * Time.fixedDeltaTime);
    }
}
