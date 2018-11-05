using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchWeapons : MonoBehaviour {

	public WeaponStates.States WeaponState;
	public UnityEvent Ax, Sword, Spear, Arrow, Bazooka, Machete;
	
	void Update () {
		switch (WeaponState)
		{
			case WeaponStates.States.Ax:
				print("You are using the Ax.");
				break;
			
			case WeaponStates.States.Sword:
				print("You are using the Sword.");
				break;
			
			case WeaponStates.States.Spear:
				print("You are using the Spear.");
				break;
			
			case WeaponStates.States.Arrow:
				print("You are using Arrows.");
				break;
			
			case WeaponStates.States.Bazooka:
				print("You are using the Bazooka.");
				break;
			
			case WeaponStates.States.Machete:
				print("You are using the Machete.");
				break;
		}
	}
}
