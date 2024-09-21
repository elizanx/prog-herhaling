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


    private void Start()
    {
        Vector3 randPosition = RandomPosition();
    }

    private Vector3 RandomPosition()
    {
        float y = UnityEngine.Random.Range(-10f, 10f);
        float x = UnityEngine.Random.Range(-10f, 10f);
        float z = UnityEngine.Random.Range(-10f, 10f);
        Vector3 randPosition = new Vector3(y, x, z);
        return randPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject towers = Instantiate(Tower);
            scale = UnityEngine.Random.Range(0, 5);
            towers.transform.localScale = new Vector3(scale, scale, scale);
            randPosition = new Vector3(UnityEngine.Random.Range(-10, 10), 0, UnityEngine.Random.Range(-10, 10));
            towers.transform.position = randPosition;
        }
    }

}
