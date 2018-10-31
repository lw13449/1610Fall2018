using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchPowerup : MonoBehaviour {

	public PowerupStates.States PowerupState;
	public UnityEvent Health, Invincibility, Invisibility, RapdiFire, SlowMo;
	
	void Update () {
		switch (PowerupState)
		{
			case PowerupStates.States.Health:
				print("Using Health Booth.");
				break;
			
			case PowerupStates.States.Invincibility:
				print("Using Invicibility.");
				break;
			
			case PowerupStates.States.Invisibility:
				print("Using Invisibility.");
				break;
			
			case PowerupStates.States.RapidFire:
				print("Using Rapid Fire.");
				break;
			
			case PowerupStates.States.SlowMo:
				print("Using Slow Mo.");
				break;
		}
	}
}
