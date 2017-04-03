using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawns bullets and checks if projectiles can be shot.
/// </summary>
public class PlayerShoot : MonoBehaviour 
{
	[SerializeField]
	private GameObject _projectile;

	[SerializeField]
	private Transform _muzzle;

	public void Shoot()
	{
		Instantiate (_projectile, _muzzle.position, _muzzle.rotation);
	}
}
