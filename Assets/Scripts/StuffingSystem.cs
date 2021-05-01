using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffingSystem : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            {
            TakeDamage(20);
        }

        if (currentHealth == 0)
        {
           print("Game Over");
        }
    }

   
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
