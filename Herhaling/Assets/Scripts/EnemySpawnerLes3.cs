using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawnerLes3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cube;
    public int enemiesPerSecond = 1;
        
    List<GameObject> gameObjects = new List<GameObject>();

    private float elapsedTime = 0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);

        elapsedTime += Time.deltaTime;

        if (elapsedTime > 3f) { 
            elapsedTime = 0f;

            spawnEnemy();


        }
        


        if (Input.GetKey(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                 
                GameObject newEnemy = Instantiate(Cube);
                gameObjects.Add(newEnemy);
                Debug.Log("werkt dit");
            }
        }

        if (Input.GetKey(KeyCode.Q))

           foreach(GameObject newEnemy in gameObjects)
           {
                Destroy(newEnemy);
                
           }
    }

    private void spawnEnemy()
    {
        for (int i = 0; i < enemiesPerSecond; i++)
        {

            GameObject newEnemy = Instantiate(Cube);
            gameObjects.Add(newEnemy);
            
        }
    }
    
}
