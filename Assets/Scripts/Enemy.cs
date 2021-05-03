using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable
{
   
    public override void Interact()
    {
        CharacterStats myStats;
        PlayerManager playerManager;
        void Start()
        {
            playerManager = PlayerManager.instance;
            myStats = GetComponent<CharacterStats>();
        }
        base.Interact();
        CharacterCombat playerCombat = playerManager.player.GetComponent<CharacterCombat>();
        if(playerCombat != null)
        {
            playerCombat.Attack();
        }
    }
}
