using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement3 : MonoBehaviour
{
    public class CubeMovementLes3 : MonoBehaviour
 {
     [SerializeField] float speed = 10f;
     // Start is called before the first frame update
     void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {
         transform.position += Vector3.forward * speed * Time.deltaTime;
     }
 }
}
