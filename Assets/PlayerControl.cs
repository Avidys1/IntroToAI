using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 20f;
    
    /*void Update()
    {
		
		if(Input.GetKey(KeyCode.D))
		{
			Vector3 playerPosition = transform.position;
			// data time, keep movement the same across framerates
			playerPosition.x = playerPosition.x + 1f * Time.deltaTime;
			transform.position = playerPosition;
			
		}
		if(Input.GetKey(KeyCode.W))
		{
			Vector3 playerPosition = transform.position;
			
			playerPosition.z = playerPosition.z + 1f * Time.deltaTime;
			transform.position = playerPosition;
			
		}
		if(Input.GetKey(KeyCode.A))
		{
			Vector3 playerPosition = transform.position;
			
			playerPosition.x = playerPosition.x - 1f * Time.deltaTime;
			transform.position = playerPosition;
		}
		if(Input.GetKey(KeyCode.S))
		{
			Vector3 playerPosition = transform.position;
			
			playerPosition.z = playerPosition.z - 1f * Time.deltaTime;
			transform.position = playerPosition;
		}
		/
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Vector3 playerPosition = transform.position;
		
			playerPosition.y += speed * Time.deltaTime;
			transform.position = playerPosition;
		}
		
		
	}
}
*/

		void Update()
		{
			float horizontal = Input.GetAxis("Horizontal");
			float vertical =   Input.GetAxis("Vertical");
			
			Camera camera = Camera.main;
			
			Vector3 forward = camera.transform.forward;
			Vector3 right = camera.transform.right;
			
			forward.y = 0f;
			right.y = 0f;
			forward.Normalize();
			right.Normalize();
			
			Vector3 desiredMoveDirection = (forward * vertical) + (right * horizontal);
			desiredMoveDirection.Normalize();
			
			//Vector3 moveDirection = new Vector3(vertical,0f,horizontal);
			transform.position += desiredMoveDirection * speed * Time.deltaTime;	
	}
}

		