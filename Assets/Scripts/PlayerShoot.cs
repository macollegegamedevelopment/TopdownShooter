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

	[SerializeField]
	private float _fireRate;

	private float _nextFireTime;

	public void Shoot()
	{
		if (Time.time >= _nextFireTime) 
		{
			Instantiate (_projectile, _muzzle.position, _muzzle.rotation);
			_nextFireTime = Time.time + _fireRate;
		}
	}
}
