using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   
    private Vector3 initialPos = new Vector3(0,0,0);

    private void Start()
    {
        transform.position = initialPos;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position += new Vector3Int(-1, 1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position += new Vector3Int(1, 1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3Int(-1, -1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3Int(1, -1, 0);
        }
    }
}
