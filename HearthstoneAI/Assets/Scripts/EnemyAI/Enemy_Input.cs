using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is to make the enemy can end its turn
/// </summary>

public class Enemy_Input : MonoBehaviour {

    private Turn_Manager turnManager;
    private Enemy_Mana _EnemyMana;
	// Use this for initialization
	void Start () {
        if (!(turnManager = this.GetComponent<Turn_Manager>()))
        {
            turnManager = this.gameObject.AddComponent<Turn_Manager>();
        }
        if (!(_EnemyMana = this.GetComponent<Enemy_Mana>()))
        {
            _EnemyMana = this.gameObject.AddComponent<Enemy_Mana>();
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (turnManager.turns != true)
        {
            
            //turnManager.turns = true;
            //Debug.Log("Player Turn");
        }
	}
}