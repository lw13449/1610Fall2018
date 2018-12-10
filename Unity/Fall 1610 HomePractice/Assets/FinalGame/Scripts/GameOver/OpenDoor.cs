using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenDoor : MonoBehaviour
{
	public FloatData Inventory, FullInventory;

	private void OnMouseDown()
	{
		if (Inventory.Value > FullInventory.Value)
		{
			print("Open Door. You have Won the Game.");
		}
		else
		{
			print("Find Key to open Door.");
		}
	}
}
