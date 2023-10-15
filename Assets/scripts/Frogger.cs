using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour
{
    private Vector3 startPosition; 
    private Vector3 moveDirection; 
    private Vector3 position;

    private UnityEngine.KeyCode prohibitedMovement; //variable so you can't go back

    // The player will move every 2 seconds
    private float moveTimer;
    private float moveTimerMax = 2f; 

    private void Awake() //As soon as the game is executed, the player is positioned at (0, 0, 0)
    {
        startPosition = new Vector3(0, 0, 0); 
        position = startPosition;
    }

    
    private void Update() //we call the movement in the Update so that it moves in each frame
    {
        Movement();
        Direction();
    }

    private void Movement() //the player will move every 2 seconds
    {
        moveTimer += Time.deltaTime;
        if (moveTimer >= moveTimerMax)
        {
            moveTimer -= moveTimerMax;

            position += moveDirection;

            transform.position = new Vector3(position.x, position.y, 0);
        }
    }

    private void Direction() //directions corresponding to each key
    {
        //direction top right

        if (Input.GetKeyDown(KeyCode.Q))
        {

            if (prohibitedMovement != KeyCode.Q) //you cannot go backwards
            {
                moveDirection.x = -1;
                moveDirection.y = 1;

                prohibitedMovement = KeyCode.D;
            }
            else
            {
                Debug.Log("You cannot return to the previous position"); 
            }
        }

        //direction up left

        else if (Input.GetKeyDown(KeyCode.E))
         {

            if (prohibitedMovement != KeyCode.E)
            {
                moveDirection.x = 1;
                moveDirection.y = 1;

                prohibitedMovement = KeyCode.A;
            }
            else
            {
                Debug.Log("You cannot return to the previous position"); 
            }
        }

        //direction bottom right

        else if (Input.GetKeyDown(KeyCode.A))
         {

            if (prohibitedMovement != KeyCode.A)
            {
                moveDirection.x = -1;
                moveDirection.y = -1;

                prohibitedMovement = KeyCode.E;
            }
            else
            {
                Debug.Log("You cannot return to the previous position");
            }

        }

        //direction down left

        else if (Input.GetKeyDown(KeyCode.D))
         {

            if (prohibitedMovement != KeyCode.D)
            {
                moveDirection.x = 1;
                moveDirection.y = -1;

                prohibitedMovement = KeyCode.Q;
             }
            else
            {
                Debug.Log("You cannot return to the previous position");
            }
        } 
    }

}
