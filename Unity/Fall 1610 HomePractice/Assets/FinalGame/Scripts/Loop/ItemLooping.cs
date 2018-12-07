using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLooping : MonoBehaviour
{

	public GameObject[] Invetory;

	private Vector3 position;

	public float Distance = 3;
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < Invetory.Length; i++)
		{
			Instantiate(Invetory[i], position, Quaternion.identity);
			position.x += Distance;
		}
	}
	
}
