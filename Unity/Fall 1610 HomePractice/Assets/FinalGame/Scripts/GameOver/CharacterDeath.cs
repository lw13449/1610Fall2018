using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDeath : MonoBehaviour {

    public GameObject Player;

	private Vector3 position;
    
	
	// Update is called once per frame
	void Update () {
		if (position.y < -20)
		{
			Destroy(gameObject);
			print("You have died.");
		}

	}
}
