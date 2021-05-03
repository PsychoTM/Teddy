using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{
    CharacterStats myStats;
    // Start is called before the first frame update
    void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }

    // Update is called once per frame
    public void Attack(CharacterStats targetStats)
    {
        targetStats.TakeDamage(myStats.damage.GetValue());
    }
}
