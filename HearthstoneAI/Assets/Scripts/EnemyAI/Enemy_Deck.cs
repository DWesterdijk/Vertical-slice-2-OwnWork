using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is the Deck of the enemy, it will track all the cards in the deck.
/// </summary>

public class Enemy_Deck : MonoBehaviour {
    
    public List<GameObject> cardsInDeck = new List<GameObject>();
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (cardsInDeck.Count > 60)
        {
            //don't add cards
        }
        if (cardsInDeck.Count < 0)
        {
            //Get damage for every turn not having a card in deck (Fatigue
            //Fatigue damage increases each turn by 1.
            //Starts with 1 damage
        }
	}
}
