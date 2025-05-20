using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Ci dessous on fit reference au rigidbody
    public Rigidbody rb;
    // La puissance d'avancement du player
    public float forwardForce = -200f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) // Quand l'user tape sur la touche 'd'
        {
            rb.AddForce(-50* Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")) // Quand l'user tape sur la touche 'q'
        {
            rb.AddForce(50* Time.deltaTime, 0, 0);
        }
    }
}