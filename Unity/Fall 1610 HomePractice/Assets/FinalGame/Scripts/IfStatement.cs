using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour {
    
    public NameID Lock, Key;
	
	
	void Update () {
		if (Lock == Key)
		{
			print("Open Door");
		}
	}
}
