using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(PlayerMovement))]
[RequireComponent (typeof(PlayerShooting))]
public class PlayerInput : MonoBehaviour 
{
	private PlayerMovement _playerMovement;
	private PlayerShooting _playerShoot;

	private Vector3 _inputDirection;

	void Awake()
	{
		_playerMovement = GetComponent<PlayerMovement> ();
		_playerShoot = GetComponent<PlayerShooting> ();
	}

	void Update()
	{
		float x = Input.GetAxisRaw ("Horizontal");
		float z = Input.GetAxisRaw ("Vertical");

		_inputDirection = new Vector3 (x, 0f, z);

		if (Input.GetMouseButton (0)) 
		{
			_playerShoot.Shoot ();
		}
	}

	private void FixedUpdate()
	{
		_playerMovement.Move (_inputDirection);
	}
}
