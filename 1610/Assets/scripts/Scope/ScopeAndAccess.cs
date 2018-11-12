using UnityEngine;

public class ParentObject : ScriptableObject
{

	public int Health = 100;
	protected float PowerLevel = 100;
}

public class ChildObject : ParentObject
{
	void Update()
	{
		Health = 90;
		PowerLevel = 1000;
	}
}

public class OutsideObject : MonoBehaviour
{
	public ParentObject Parent;

	private void Update()
	{
		Parent.Health = 80;
	}
}
