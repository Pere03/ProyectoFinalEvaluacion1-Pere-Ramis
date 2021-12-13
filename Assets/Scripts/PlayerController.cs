using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float TurnSpeed;
    private float verticalInput;
    private float horizontalInput;
    public float negRange = -200f;
    public float posRange = 200f;

    void Start()
    {
       
    }

    
    void Update()
    {
        //Con esto avanza hacia delante de forma automatica
       
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

      
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.left * TurnSpeed * Time.deltaTime * verticalInput);

       
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.back * TurnSpeed * Time.deltaTime * horizontalInput);

        /*
        if (transform.Rotate.x > posRange)
        {
            transform.Rotate = new Vector3(posRange, transform.Rotate.y,
                transform.Rotate.z);
        }
        */
    }
}
