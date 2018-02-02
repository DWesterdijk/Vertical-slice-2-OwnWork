using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is the Input manager. (TEMP SCRIPT!)
/// </summary>

public class OnFieldCards : MonoBehaviour {
    
    public List<GameObject> onEnemyField = new List<GameObject>();
    public List<GameObject> onPlayerField = new List<GameObject>();
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (onEnemyField.Count >= 6)
        {

        }
        if (onPlayerField.Count >= 6)
        {

        }
	}
}