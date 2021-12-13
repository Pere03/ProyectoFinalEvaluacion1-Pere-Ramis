using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float TurnSpeed;
    private float horizontalInput;

    void Update()
    {
        
        transform.Rotate(Vector3.up * TurnSpeed * Time.deltaTime);
    }
}
