using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    Quaternion originRotation;
    float angleHorizontation;
    float angleVertical;
    [SerializeField] float mouseSensitiveRight = 5f;
    [SerializeField] float mouseSensitiveUp =3f;
    private void Start()
    {
        originRotation = transform.rotation;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void FixedUpdate()
    {
        angleHorizontation += Input.GetAxis("Mouse X");
        angleVertical += Input.GetAxis("Mouse Y") * mouseSensitiveRight;
        angleVertical = Mathf.Clamp(angleVertical, -60, 60);
        Quaternion RotationY = Quaternion.AngleAxis(angleHorizontation * mouseSensitiveUp, Vector3.up);
        Quaternion RotationX = Quaternion.AngleAxis(-angleVertical, Vector3.right);
        
        transform.rotation = originRotation * RotationY * RotationX;

        //movement if u 
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward/2;
        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward/2;
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right;
        if (Input.GetKey(KeyCode.A))
            transform.position -= transform.right;
    }
}
