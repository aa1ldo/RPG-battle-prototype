using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public int dmgRecieved;

    public EnemyHealth healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage()
    {
        currentHealth -= dmgRecieved;
        healthBar.SetHealth(currentHealth);
    }
}
