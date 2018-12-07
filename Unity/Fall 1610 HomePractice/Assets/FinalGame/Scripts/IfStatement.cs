using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour {
    
    public NameID Door, Key;
	
	
	void Update () {
		if (Door == Key)
		{
			print("Open Door");
			print("You have Won.");
		}
		else
		{
			print("Find Key to Open Door.");
		}
	}
}
