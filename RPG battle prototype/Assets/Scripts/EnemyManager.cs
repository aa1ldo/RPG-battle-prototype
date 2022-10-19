using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public int damage;
    public int defense;
    public float critMultiplier;
    public float damageDelay;
    public string currentStyle;
    float styleMultiplier;
    string[] styles = { "CUTE", "CASUAL", "EDGY" };

    float damageDealt;

    int hitChance;
    int missChance;

    public EnemyHealth healthBar;

    public PlayerManager playerManager;

    public Button attackButton;

    private void OnEnable()
    {
        currentStyle = styles[Random.Range(0, 3)];

        // Calculating style effectiveness:

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        if (currentHealth <= 0f)
        {
            GameManager.Instance.YouWin = true;
            GameManager.Instance.BattleOver = true;
        }
    }

    // Player attacks:

    public void Attack()
    {
        StartCoroutine(DamageProcess());
    }

    IEnumerator DamageProcess() // adds a cooldown to the attack button
    {
        TakeDamage();
        attackButton.interactable = false;
        yield return new WaitForSeconds(playerManager.damageDelay);
        attackButton.interactable = true;
    }
    void TakeDamage()
    {
        hitChance = Random.Range(1, 10);
        missChance = Random.Range(1, 10) - 2;

        if(hitChance > missChance)
        {
            damageDealt = playerManager.damage * 100 / (100 + defense) * styleMultiplier;
        }
        else if(hitChance == missChance)
        {
            damageDealt = playerManager.damage * critMultiplier;
        }
        else
        {
            damageDealt = 0f;
        }

        Debug.Log("Damage dealt: " + damageDealt);

        currentHealth -= damageDealt;

        healthBar.SetHealth(currentHealth);
    }

    /*
     * CALCULATING DAMAGE:
     * 1. hitChance = r(1,10)
     * 2. missChance = r(1,10) - 2
     * 3. if hitChance > missChance, then
     *      health -= damage / (defense + 100 / 100)
     * 4. else miss
     * 
     * there will ALWAYS be damage dealt unless hit rolls less.
     * crit attacks ALWAYS ignore defense.
     */
}
