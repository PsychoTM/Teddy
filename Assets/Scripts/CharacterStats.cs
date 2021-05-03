using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class CharacterStats : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxHealth = 100f;
    public float maxStamina = 100f;
    public float currentHealth { get; private set; }
    public float currentStamina;
    float lastRegen = 0f;
    float staminaRegenSpeed = 1f;
    float staminaRegenAmount = 5f;
    public Stats damage;

    NavMeshAgent agent;
    void Awake()
    {
        currentStamina = maxStamina;
        currentHealth = maxHealth;
    }



    public void TakeDamage(int damage)
    {

        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage ");

        if (currentHealth <= 0)
        {
            Die();
        }
    }



    public virtual void Die()
    {
        Debug.Log(transform.name + " died.");
        Destroy(gameObject);
        Debug.Log("Game Over");
    }



    
}
