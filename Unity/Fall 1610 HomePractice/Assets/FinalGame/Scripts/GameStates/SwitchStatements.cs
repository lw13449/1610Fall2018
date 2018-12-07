using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchStatements : MonoBehaviour
{

	public GameStates.States GameState;

	public UnityEvent Starting, Playing, Ending, Dying;
	
	// Update is called once per frame
	void Update () {
		switch (GameState)
		{
				case GameStates.States.Starting:
					print("The game is starting");
					break;
				case GameStates.States.Playing:
					print("You are playing the Game");
					break;
				case GameStates.States.Dying:
					print("You are Dead");
					break;
				case GameStates.States.Winning:
					print("You have won");
					break;
		}
	}
}
