using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterLoop : MonoBehaviour
{

	public string[] Alphabet;
	
	// Use this for initialization
	void Start () {
		foreach (var letter in Alphabet)
		{
			print(letter);
		}
	}
	
}
