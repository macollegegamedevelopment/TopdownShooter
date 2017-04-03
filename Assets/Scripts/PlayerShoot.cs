using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Instatiate bullets so that the player can shoot.
/// </summary>
public class PlayerShoot : MonoBehaviour 
{
	[SerializeField]
	private GameObject _projectile;

	[SerializeField]
	private Transform spawnpoint;

	[SerializeField]
	private float _fireRate;

	private float _nextFireTime;

	public void Shoot()
	{
		if (Time.time >= _nextFireTime) 
		{
			SpawnProjectile ();
		}
	}

	private void SpawnProjectile()
	{
		Instantiate (_projectile, spawnpoint.position, spawnpoint.rotation);
		_nextFireTime = Time.time + _fireRate;
	}
}
