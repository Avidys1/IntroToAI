using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class RadomMove : MonoBehaviour
{
    NavMeshAgent _agent;
	
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
		if(Vector3.Distance(_agent.destination, transform.position) < 2f)
		{
			float randomsX = Random.Range(-5f, 5f);
			float randomsZ = Random.Range(-5f, 5f);
			
			Vector3 randomPosition = new Vector3(transform.position.x + randomsX, transform.position.y, transform.position.z + randomsZ);
			_agent.destination = randomPosition;
		}
    }
}
