using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket2AI : MonoBehaviour
{
    public float movementSpeed;

    public GameObject ball;

    private void FixedUpdate()
    {
        if(Mathf.Abs(this.transform.position.y - ball.transform.position.y) > 50)
        {
            if(transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movementSpeed; //yukar� oynat
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * movementSpeed; //a�a�� oynat

            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0); //hi� oynatma

        }
    }
}
