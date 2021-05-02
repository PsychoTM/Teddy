using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Interactable
{
    // Start is called before the first frame update
    PlayerManager playerManager;
    CharacterStats myStats;
    

    void start ()
    {
        playerManager = PlayerManager.instance;
        myStats = getComponent<CharacterStats>();

    }
    public override void Interact()
    {
        base.Interact();
        CharacterCombat playerCombat = playerManager.player.GetComponent<CharacterComabt>();
        if(playerCombat != null)
        {
            playerCombat.Attack(myStats);
        }
    }
}
