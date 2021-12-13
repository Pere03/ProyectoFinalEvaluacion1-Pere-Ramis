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
    public GameObject projectilPrefab;
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
        transform.Rotate(Vector3.up * TurnSpeed * Time.deltaTime * horizontalInput);

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            projectilPrefab.transform.rotation = gameObject.GetComponent<Transform>().rotation;

            Instantiate(projectilPrefab, transform.position,
                projectilPrefab.transform.rotation);
        }
    }
}
