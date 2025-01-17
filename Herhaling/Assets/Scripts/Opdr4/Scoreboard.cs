using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    private int score = 0;
    private TMPro.TextMeshPro Text;

    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TMPro.TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Points()
    {
        Scoreboard scoreboard = new Scoreboard();
    }
}
