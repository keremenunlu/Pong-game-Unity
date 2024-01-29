using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;

        Vector3 racketPositon = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;

        if(c.gameObject.name == "Racket1")
        {
            x = 1;
        }
        else
        {
            x = -1; 
        }

        float y = (ballPosition.y - racketPositon.y) / racketHeight;

        this.ballMovement.increaseHitCounter();
        this.ballMovement.moveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Racket1" || collision.gameObject.name == "Racket2")
        {
            this.BounceFromRacket(collision);
        }
        else if(collision.gameObject.name == "WallLeft")
        {
            Debug.Log("Collision with left wall.");

            this.scoreController.GoalPlayer2();

            StartCoroutine(this.ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Collision with right wall.");

            this.scoreController.GoalPlayer1();
            StartCoroutine(this.ballMovement.StartBall(false));

        }
    }
}
