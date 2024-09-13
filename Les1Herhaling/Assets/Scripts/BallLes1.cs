using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    private float elapsedTime = 0f;

    private Vector3 randomPosition;

    

    private void CreateBall()
    {
        Instantiate(prefab);
    }

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Color color = RandomColor();
            Vector3 randPos = RandomPosition();
            CreateBall(color, randPos);
           
        }
        

    }

    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);
        return randColor;
    }

    private Vector3 RandomPosition()
    {
        float y = Random.Range(0f, 1f);
        float x = Random.Range(0f, 1f);
        float z = Random.Range(0f, 1f);
        Vector3 randPosition = new Vector3(y, x, z);
        return randPosition;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
            GameObject newBall = CreateBall(RandomColor(), RandomPosition());
            elapsedTime = 0.5f;
            DestroyBall(newBall);
        }
    }

    private GameObject CreateBall(Color c, Vector3 randomPosition)
    {
        GameObject ball = Instantiate(prefab);
        Material mat = ball.GetComponent<MeshRenderer>().material;
        randomPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        ball.transform.position = randomPosition;

        if (mat.shader.name == "Universal Render Pipeline/Lit")
        {
            mat.SetColor("_BaseColor", c);
        }

        return ball;
    }

    
    private void DestroyBall(GameObject ball)
    {
      Destroy(ball, 3f);
    }


}
