using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour
{
    private Vector3 startPosition; 
    private Vector3 moveDirection; 
    private Vector3 position;

    // El jugador se moverá a cada 2 segundos
    private float moveTimer;
    private float moveTimerMax = 2f; 

    private void Awake()
    {
        startPosition = new Vector3(0, 0, 0); 
        position = startPosition;
    }

    
    private void Update() //llamamos el movimiento en el Update para que se mueva en cada frame
    {
        Movement();
        Direction();
    }

    private void Movement() //se moverá cada 2 segundos
    {
        moveTimer += Time.deltaTime;
        if (moveTimer >= moveTimerMax)
        {
            moveTimer -= moveTimerMax;

            position += moveDirection;

            transform.position = new Vector3(position.x, position.y, 0);
        }
    }

    private void Direction() //direcciones correspondientes a cada tecla
    {
        //dirección arriba derecha
       
            if (Input.GetKeyDown(KeyCode.Q))
            {
                moveDirection.x = -1;
                moveDirection.y = 1;
            }
        
        //dirección arriba izq

            if (Input.GetKeyDown(KeyCode.E))
            {
                moveDirection.x = 1;
                moveDirection.y = 1;
            }
        
        //dirección abajo der

            if (Input.GetKeyDown(KeyCode.A))
            {
                moveDirection.x = -1;
                moveDirection.y = -1;
            }
        
        //dirección abajo izq

            if (Input.GetKeyDown(KeyCode.D))
            {
                moveDirection.x = 1;
                moveDirection.y = -1;
            }
    }

}
