using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is to set and keep track of all the
/// cards values.
/// Values are:
/// Mana
/// HP
/// ATK
/// SpellPower
/// Windfury
/// Silence
/// </summary>

public class Card_Stats : MonoBehaviour {

    //ints
    public int cMana;
    public int cHealth;
    public int cAttack;
    public int cSpellPower;

    //bools
    public bool cWindfury;
    public bool cSilence;
    public bool cTaunt;
    public bool cDivineShield;
    public bool cCharge;
    public bool cDeathRattle;
    public bool cBattleCry;

    public bool canPlayCard;

    void Start()
    {
        canPlayCard = true;
    }

    void Update()
    {
       if (cHealth <= 0)
       {
            Destroy(this.gameObject);
            //Card is dead
       } 
    }
}
