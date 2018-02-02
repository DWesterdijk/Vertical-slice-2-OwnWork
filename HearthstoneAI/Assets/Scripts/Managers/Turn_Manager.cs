using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script manages the turns.
/// Who's turn it is and how many mana crystals you get.
/// 
/// After 45 turns the game gets forced to end.
/// </summary>

public class Turn_Manager : MonoBehaviour {

    private Input_Managing inputManager;
    private Enemy_Mana _enemyMana;
    private Enemy_Hand _enemyHand;
    private Enemy_Deck _enemyDeck;

    public bool turns;

    // Use this for initialization
    void Start ()
    {
        Debug.Log("Test");

        turns = true;

        if (!(inputManager = this.GetComponent<Input_Managing>()))
        {
            inputManager = this.gameObject.AddComponent<Input_Managing>();
        }
        if (!(_enemyMana = this.GetComponent<Enemy_Mana>()))
        {
            _enemyMana = this.gameObject.AddComponent<Enemy_Mana>();
        }
        if (!(_enemyHand = this.GetComponent<Enemy_Hand>()))
        {
            _enemyHand = this.gameObject.AddComponent<Enemy_Hand>();
        }
        if (!(_enemyDeck = this.GetComponent<Enemy_Deck>()))
        {
            _enemyDeck = this.gameObject.AddComponent<Enemy_Deck>();
        }
    }

    void Update()
    {
    if (turns != false)
        {
            if (inputManager.Action())
            {
                if (turns == true)
                {
                    turns = false;
                     _enemyMana.manaMax += 1;
                    _enemyMana.currentMana = _enemyMana.manaMax;
                    Debug.Log("Enemy turn");
                }
            }
        }
    }

    /*void DrawCard()
    {
        //This lets you draw a card at the start of the game
        if(_enemyHand.CardsInHand.Count < 10)
        {
            _enemyHand.CardsInHand.Add();
        }
    }

    void StartGame()
    {
        for (int i = 0; i < 3; i++)
        {
            _enemyHand.CardsInHand
        }
    }*/
}
