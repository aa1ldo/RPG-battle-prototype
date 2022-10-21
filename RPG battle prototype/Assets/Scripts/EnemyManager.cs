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
    public float styleMultiplier = 1f;
    string[] styles = { "CUTE", "CASUAL", "EDGY" };

    float damageDealt;

    int hitChance;
    int missChance;

    public EnemyHealth healthBar;

    public PlayerManager playerManager;

    public Button attackButton;

    public Animator playerAnim;

    private void OnEnable()
    {
        currentStyle = styles[Random.Range(0, 3)];

        // SET ENEMY STATS HERE BASED ON STYLE
        // ......

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        if (currentHealth <= 0f)
        {
            GameManager.Instance.YouWin = true;
            GameManager.Instance.BattleOver = true;

            attackButton.interactable = true;
        }

        // Calculate style effectivness
        if (currentStyle == "CUTE" && playerManager.currentStyle == "EDGY")
        {
            styleMultiplier = 1.1f;
        }
        else if (currentStyle == "EDGY" && playerManager.currentStyle == "CASUAL")
        {
            styleMultiplier = 1.1f;
        }
        else if (currentStyle == "CASUAL" && playerManager.currentStyle == "CUTE")
        {
            styleMultiplier = 1.1f;
        }
        else if (currentStyle == "EDGY" && playerManager.currentStyle == "CUTE")
        {
            styleMultiplier = 1f;
        }
        else if (currentStyle == "CUTE" && playerManager.currentStyle == "CASUAL")
        {
            styleMultiplier = 1f;
        }
        else if (currentStyle == "CASUAL" && playerManager.currentStyle == "EDGY")
        {
            styleMultiplier = 1f;
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
            // Play PLAYER attack animation
            playerAnim.SetTrigger("Hit");
            damageDealt = playerManager.damage * 100 / (100 + defense) * styleMultiplier;
        }
        else if(hitChance == missChance)
        {
            // Play PLAYER attack animation
            playerAnim.SetTrigger("Crit");
            damageDealt = playerManager.damage * critMultiplier;
        }
        else
        {
            // Play PLAYER miss animation
            playerAnim.SetTrigger("Miss");
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
