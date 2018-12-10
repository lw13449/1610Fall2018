using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDeath : MonoBehaviour {

	public FloatData Health, minHealth;
    
	
	// Update is called once per frame
	void Update () {
		if (Health.Value <= minHealth.Value)
		{
			print("You have died.");
			Destroy(gameObject);
		}

	}
}
