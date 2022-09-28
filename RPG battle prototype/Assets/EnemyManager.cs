using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public int damage = 2;

    public EnemyHealth healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Controlled by attack button:
    public void TakeDamage()
    {
        currentHealth -= damage;

        // If pressed for the first time, start the coroutine that carries out enemy attacks
    }
}
