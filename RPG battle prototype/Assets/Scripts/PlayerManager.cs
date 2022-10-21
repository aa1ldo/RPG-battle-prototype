using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public int damage;
    public int defense;
    public float critMultiplier;
    public float damageDelay;
    public string currentStyle;

    public float styleMultiplier = 1f;

    float damageDealt;

    int hitChance;
    int missChance;

    public PlayerHealth healthBar;

    public EnemyManager enemyManager;

    public OutfitSelect outfitSelect;

    private void Start()
    {
        if (outfitSelect.CalculateStyle() == 0)
        {
            currentStyle = "CUTE";
        }
        else if (outfitSelect.CalculateStyle() == 1)
        {
            currentStyle = "CASUAL";
        }
        else if (outfitSelect.CalculateStyle() == 2)
        {
            currentStyle = "EDGY";
        }
    }

    private void OnEnable()
    {
        // SET PLAYER STATS HERE BASED ON STYLE
        // ......

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        StartCoroutine(DamageProcess());
    }

    private void Update()
    {
        if (currentHealth <= 0f)
        {
            GameManager.Instance.YouWin = false;
            GameManager.Instance.BattleOver = true;
        }

        // Calculate style effectiveness:

        if (currentStyle == "CUTE" && enemyManager.currentStyle == "EDGY")
        {
            styleMultiplier = 1.1f;
        }
        else if (currentStyle == "EDGY" && enemyManager.currentStyle == "CASUAL")
        {
            styleMultiplier = 1.1f;
        }
        else if (currentStyle == "CASUAL" && enemyManager.currentStyle == "CUTE")
        {
            styleMultiplier = 1.1f;
        }
        else if (currentStyle == "EDGY" && enemyManager.currentStyle == "CUTE")
        {
            styleMultiplier = 1f;
        }
        else if (currentStyle == "CUTE" && enemyManager.currentStyle == "CASUAL")
        {
            styleMultiplier = 1f;
        }
        else if (currentStyle == "CASUAL" && enemyManager.currentStyle == "EDGY")
        {
            styleMultiplier = 1f;
        }
    }

    // Enemy attacks:
    IEnumerator DamageProcess()
    {
        while (true)
        {
            hitChance = Random.Range(1, 10);
            missChance = Random.Range(1, 10) - 2;

            if (hitChance > missChance)
            {
                damageDealt = enemyManager.damage * 100 / (100 + defense) * styleMultiplier;
            }
            else if (hitChance == missChance)
            {
                damageDealt = enemyManager.damage * critMultiplier * styleMultiplier;
            }
            else
            {
                damageDealt = 0f;
            }

            // Play ENEMY attack animation

            currentHealth -= damageDealt;
            healthBar.SetHealth(currentHealth);

            Debug.Log("Ouch");

            yield return new WaitForSeconds(enemyManager.damageDelay);
        }
    }
}
