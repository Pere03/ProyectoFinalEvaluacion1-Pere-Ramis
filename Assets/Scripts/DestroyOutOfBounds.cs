using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xPosLim = 200;
    private float xNegLim = -200;
    private float yPosLim = 200;
    private float yNegLim = 0;
    private float zPosLim = 200;
    private float zNegLim = -200;
    void Start()
    {
        
    }

    
    void Update()
    {
        //Limite de la posicion X en el que se destruira
        if (transform.position.x > xPosLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < xNegLim)
        {
            Destroy(gameObject);
        }

        //Limite de la posicion Y en el que se destruira
        if (transform.position.y > yPosLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < yNegLim)
        {
            Destroy(gameObject);
        }

        //Limite de la posicion Z en el que se destruira
        if (transform.position.z > zPosLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < zNegLim)
        {
            Destroy(gameObject);
        }

    }
}
