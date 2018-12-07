using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoop : MonoBehaviour
{

	public GameObject[] Inventory;

	private Vector3 position;
	
	// Use this for initialization
	void Start () {
		foreach (var item in Inventory)
		{
			position.x += 2.5f;
			Instantiate(item, position, Quaternion.identity);
		}
	}
	
	
}
