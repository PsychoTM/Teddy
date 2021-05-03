using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable
{
<<<<<<< HEAD
   
=======
    // Start is called before the first frame update
    PlayerManager playerManager;
    CharacterStats myStats;
    

    void start ()
    {
        playerManager = PlayerManager.instance;
        myStats = getComponent<CharacterStats>();

    }
>>>>>>> ce3424ea3fae258f37923507971347738ee49f8f
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
<<<<<<< HEAD
        CharacterCombat playerCombat = playerManager.player.GetComponent<CharacterCombat>();
        if(playerCombat != null)
        {
            playerCombat.Attack();
=======
        CharacterCombat playerCombat = playerManager.player.GetComponent<CharacterComabt>();
        if(playerCombat != null)
        {
            playerCombat.Attack(myStats);
>>>>>>> ce3424ea3fae258f37923507971347738ee49f8f
        }
    }
}
