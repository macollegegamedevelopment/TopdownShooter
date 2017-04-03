using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for reading the input of the player
/// Mouse and / or Keyboard
/// </summary>
public class PlayerInput : MonoBehaviour 
{
	private PlayerMovement _playerMovement;
	private PlayerShoot _playerShoot;

	void Awake()
	{
		_playerMovement = GetComponent<PlayerMovement> ();
		_playerShoot = GetComponent<PlayerShoot> ();
	}

	void Update()
	{
		// convert pixel coords of mouse to ray.
		// A ray is an invisible line between two points
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		Debug.DrawRay (ray.origin, ray.direction * 100);

		if (Physics.Raycast (ray, out hit)) 
		{
			_playerMovement.LookAt (hit.point);	
		}

		if (Input.GetMouseButton (0)) 
		{
			_playerShoot.Shoot ();
		}
	}
}
