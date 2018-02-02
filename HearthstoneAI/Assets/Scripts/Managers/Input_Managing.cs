using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is the Input manager. (TEMP SCRIPT!)
/// </summary>

public class Input_Managing : MonoBehaviour {

	public bool Action()
    {
        return Input.GetButton("ActionButton");
    }
}
