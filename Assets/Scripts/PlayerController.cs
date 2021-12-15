using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float TurnSpeed;
    private float verticalInput;
    private float horizontalInput;
    public GameObject projectilPrefab;
    public int Counter;
    private float xPosLim = 200;
    private float xNegLim = -200;
    private float yPosLim = 200;
    private float yNegLim = 0;
    private float zPosLim = 200;
    private float zNegLim = -200;

    void Start()
    {
        transform.position = new Vector3(0, 100, 0);
    }

    
    void Update()
    {
        //Con esto avanza hacia delante de forma automatica
       
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

      //Con esto hacemos el movimiento vertical
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.left * TurnSpeed * Time.deltaTime * verticalInput);

        //Con esto hacemos el movimiento horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * TurnSpeed * Time.deltaTime * horizontalInput);

        //Esto hace que si pulsamos control, instanciara el proyectil
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            projectilPrefab.transform.rotation = gameObject.GetComponent<Transform>().rotation;

            Instantiate(projectilPrefab, transform.position,
                projectilPrefab.transform.rotation);
        }

        //Limita la posicion en X a los maximos/minimos que le hemos dado
        if (transform.position.x > xPosLim)
        {
            transform.position = new Vector3(xPosLim, transform.position.y,
                transform.position.z);
        }

        if (transform.position.x < xNegLim)
        {
            transform.position = new Vector3(xNegLim, transform.position.y,
                transform.position.z);
        }

        //Limita la posicion en Y a los maximos/minimos que le hemos dado
        if (transform.position.y > yPosLim)
        {
            transform.position = new Vector3(transform.position.x, yPosLim,
                transform.position.z);
        }

        if (transform.position.y < yNegLim)
        {
            transform.position = new Vector3(transform.position.x, yNegLim,
                 transform.position.z);
        }

        //Limita la posicion en Z a los maximos/minimos que le hemos dado
        if (transform.position.z > zPosLim)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
                zPosLim);
        }

        if (transform.position.z < zNegLim)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
                 zNegLim);
        }
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        //Esto hace que si colision contra algo que tenga el tag coin, se destruira el objeto que lo tiene, y le sumara 1 al contador
        if (otherCollider.gameObject.CompareTag("Coin"))
        {
            Destroy(otherCollider.gameObject);
            Counter += 1;
        }

        //Esto hace que si llega el contador a 10, se acaba el juego
        if(Counter == 10)
        {
            Debug.Log("THE END");
            Time.timeScale = 0;
        }

        if (otherCollider.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
    }
}
