using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawnerLes3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cube;

    List<GameObject> gameObjects = new List<GameObject>();

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);


        if (Input.GetKey(KeyCode.W))
        {
            {
                for (int i = 100; i < gameObjects.Count; i++) ;
            }
        }

        GameObject newEnemy = Instantiate(Cube);
        gameObjects.Add(newEnemy);
    }

    private void SpawnEnemies()
    {
        GameObject newEnemy = Instantiate(Cube);
        gameObjects.Add(newEnemy);



        for (int i = 0; i < gameObjects.Count; i++)
        {
            Destroy(gameObjects[i]);
        }
        gameObjects.Clear();
    }
}
