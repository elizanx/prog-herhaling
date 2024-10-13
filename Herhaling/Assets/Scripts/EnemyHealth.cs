using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int MaxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int Damage)
    {
        if(currentHealth <= 0)
        {
            Die();
        }
    }   
    void Die()
    {
       Destroy(gameObject);
    }
}
