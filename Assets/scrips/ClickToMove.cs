using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class ClickToMove : MonoBehaviour

{
    NavMeshAgent _agent;
	RaycastHit _hitInfo = new RaycastHit();
    void Start()
    {
         _agent = GetComponent<NavMeshAgent>();
    }

  
    void Update()
	
    {
        if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray.origin, ray.direction, out _hitInfo))
			{
				_agent.destination = _hitInfo.point; 
			}
			else
			{
				_agent.destination = transform.position;
			}
		}
    }
}
