using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour
{

	private NavMeshAgent agent;
	public Transform Destination;
	
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
	{
		agent.destination = Destination.position;
	}
}
