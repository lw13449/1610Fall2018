using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class StateMachine : ScriptableObject
{

	public GameStates.States GameState;

	public UnityEvent Starting, Loading, Playing, Ending, Dying;
	
	// Update is called once per frame
	public Run () {
		switch (GameState)
		{
				case GameStates.States.Starting:
					Starting.Invoke();
					break;
		}
	}
}
