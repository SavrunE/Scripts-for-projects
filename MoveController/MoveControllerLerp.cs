using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControllerLerp : MonoBehaviour
{
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 endPosition;
    [SerializeField] private float step = 0.5f;
    private float progress;

    private void Start()
    {
        transform.position = startPosition;
    }
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, progress);
        progress += step;
    }
}
