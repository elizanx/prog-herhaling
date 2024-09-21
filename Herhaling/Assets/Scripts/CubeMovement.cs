using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    GameObject prefab;
    public float speed = 10f;

    Rigidbody rb;

    private void Cube()
    {
        Instantiate(prefab);
    }

   
    void Start()
    {
        
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += transform.forward;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position -= transform.forward;
        }
    }

   
}
