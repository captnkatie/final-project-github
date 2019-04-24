using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
   
    public Vector3 initialPosition;
    public float direction;
    public float maxDist;
    public float minDist;
    public float movingSpeed;
    private bool m_FacingRight;

    void Start()
    {
        initialPosition = transform.position;
        direction = -1;
        maxDist += transform.position.x;
        minDist = transform.position.x - 2;
        m_FacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        switch (direction)
        {
            case -1:
                // Moving Left
                if (transform.position.x > minDist)
                {
                    
                    GetComponent<Rigidbody2D>().velocity = new Vector2(-movingSpeed, GetComponent<Rigidbody2D>().velocity.y);
                }
                else
                {
                    Flip();
                    direction = 1;
                }
                break;
            case 1:
                //Moving Right
                if (transform.position.x < maxDist)
                {
                    
                    GetComponent<Rigidbody2D>().velocity = new Vector2(movingSpeed, GetComponent<Rigidbody2D>().velocity.y);
                }
                else
                {
                    direction = -1;
                    Flip();
                }
                break;
        }
    }
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}



