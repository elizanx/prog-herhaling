using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    Rigidbody rb;

    GameObject prefab;
    [SerializeField] private float playerSpeed = 10f;


    private void Cube()
    {
        Instantiate(prefab);
    }

   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalMove, 0, verticalMove);
        move *= Time.deltaTime * playerSpeed;
        transform.position += new Vector3(move.x, 0, move.z);


       
    }

   
}
