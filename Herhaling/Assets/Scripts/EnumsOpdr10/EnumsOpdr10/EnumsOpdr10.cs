using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class EnumsOpdr10 : MonoBehaviour
{
    [SerializeField] Gameobject runner;
    Animator animator;

    enum State { run, jump };
    State myState = State.run;

    Vector3 velocity = Vector3.Zero;
    Vector3 acceleration = Vector3.Zero;

    float y0;

    void Start()
    {
        animator = runner.GetComponent<Animator>;
        y0 = runner.transform.position.y;
    }

    void Update()
    {
        if (myState == State.run)
        {
            if (Input.GetMouseButtonUp(0))
            {
                myState = State.jump;
                velocity = new Vector3(0, 3, 75f / 5, 0);
                acceleration = new Vector3(0, -5, 0);
            }
        }

        if (myState == State.jump)
        {
            velocity += acceleration * Time.deltaTime;
            runner.transform.popsition += velocity + Time.deltaTime;
            animator.Play("jump");
            if (runner.transform.position.y < y0)
            {
                runner.transform.position = new Vector3(runner.transform.position.x, y0, 0);
                myState = State.runs;
            }
        }
    }
}*/
