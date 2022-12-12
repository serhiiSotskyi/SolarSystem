using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturnRotation : MonoBehaviour
{
    public Transform rotatingObject;
    public float period;
    private float speed;
    private Transform _rotator;

    private void Start()
    {
        
        _rotator = GetComponent<Transform>();
    }
    private void Update()
    {
        speed = 360f / period;
        _rotator.Rotate(0, speed * Time.deltaTime, 0);
    }
}
