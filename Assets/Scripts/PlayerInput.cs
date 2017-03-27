using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles all mouse and keyboard input
/// provided by the user.
/// </summary>
public class PlayerInput : MonoBehaviour 
{
	private PlayerMovement _playerMovement; 

	void Awake()
	{
		_playerMovement = GetComponent<PlayerMovement> ();
	}

	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit))
		{
			print (hit.collider.name);
			_playerMovement.LookAt(hit.point);
			Debug.DrawRay (ray.origin, ray.direction * 100);
		}
	}
}
