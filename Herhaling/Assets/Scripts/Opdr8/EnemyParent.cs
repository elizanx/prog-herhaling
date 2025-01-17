using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    [SerializeField] Transform[] Points;

    [SerializeField] private float moveSpeed;

    private int pointsIndex; //telt de hoeveelheid waypoints er zijn

    public int MaxHealth = 100;
    private int currentHealth;
    public int Damage = 15;

    private void Start()
    {
        transform.position = Points[pointsIndex].transform.position;
        currentHealth = MaxHealth;
    }

    private void Update()
    {
        if (pointsIndex <= Points.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Points[pointsIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == Points[pointsIndex].transform.position)
            {
                pointsIndex += 1; //er wordt hier telkens een waypoint bij geteld
            }

        }
    }


    public void TakeDamage(int Damage)
    {
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider bullet)
    {
        EnemyHealth enemy = bullet.GetComponent<EnemyHealth>();

        if (enemy != null)
        {
            enemy.TakeDamage(Damage);
        }
    }
}
