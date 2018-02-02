using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is the mana of the enemy.
/// if it reaches 10, it stays 10.
/// </summary>

public class Enemy_Mana : MonoBehaviour {

    public int manaMax = 0;
    public int currentMana = 0;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
		if (manaMax >= 10)
        {
            manaMax = 10;
        }
        if (currentMana >= 10)
        {
            currentMana = 10;
        }
        Debug.Log("Enemy Mana: " + currentMana);
	}
}
