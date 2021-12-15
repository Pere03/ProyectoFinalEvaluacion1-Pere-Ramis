using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColision : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherCollider)
    {
        //Destruye el proyectil
        if (otherCollider.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
       
        //Destruye el objeto contra el que colisiona
        if (otherCollider.gameObject.CompareTag("Obstacle"))
        {
            Destroy(otherCollider.gameObject);
        }
    }
}
