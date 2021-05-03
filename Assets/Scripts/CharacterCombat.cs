using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{
    CharacterStats myStats;
    public float attackSpeed = 1f;
    public float attackCooldown = 0f;
    // Start is called before the first frame update
    void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }
    void Update()
    {
        attackCooldown -= Time.deltaTime;
    }

    // Update is called once per frame
    public void Attack(CharacterStats targetStats)
    {
        if (attackCooldown <= 0f) 
        { 
        myStats.currentStamina -= 10f;
        targetStats.TakeDamage(myStats.damage.GetValue());
            attackCooldown = 1f / attackSpeed;
        }
    }
}
