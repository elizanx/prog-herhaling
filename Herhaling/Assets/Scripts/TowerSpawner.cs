using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;


public class TowerSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject Tower;
    private float scale;
    private Vector3 randPosition;


    // Update is called once per frame
    void Update()
    {
             float x = UnityEngine.Random.Range(0, 5);
             float y = UnityEngine.Random.Range(0, 5);
             float z = UnityEngine.Random.Range(0, 5);
        


        if (Input.GetMouseButtonDown(0))
        {
            GameObject towers = Instantiate(Tower);
            scale = UnityEngine.Random.Range(0, 5);
            towers.transform.localScale = new Vector3(scale, scale, scale);
            randPosition = new Vector3(UnityEngine.Random.Range(-10, 10) ,0 , UnityEngine.Random.Range(-10, 10));
            towers.transform.position = randPosition;
        }
    }
}
