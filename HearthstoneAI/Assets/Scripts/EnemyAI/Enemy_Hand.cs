using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// In here the cards of the enemy will be counted.
/// </summary>

public class Enemy_Hand : MonoBehaviour {

    public List<GameObject> CardsInHand = new List<GameObject>();

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
		if (CardsInHand.Count >= 10)
        {
            Debug.Log("Hand is full");
            //Burn the card that is drawn
        }
	}
}
