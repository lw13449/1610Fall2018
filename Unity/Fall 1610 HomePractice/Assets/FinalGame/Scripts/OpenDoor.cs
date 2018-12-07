using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	public bool OpenDoor;
	
	void Update () {
		if (OpenDoor)
		{
			GameStates.States.Winning;
			print("You have won.");
		}
		
		else
		{
			GameStates.States.Playing;
		}
	}
}
