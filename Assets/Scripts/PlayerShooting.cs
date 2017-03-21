using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour 
{
	[SerializeField]
	private Bullet _bullet;

	[SerializeField]
	private Transform _muzzle;

	[SerializeField]
	private float _fireRate;

	private float _nextFireTime;

	public void Shoot()
	{
		if (Time.time >= _nextFireTime) 
		{
			CreateBullet ();
		}
	}

	private void CreateBullet()
	{
		Instantiate (_bullet, _muzzle.position, _muzzle.rotation);
		_nextFireTime = Time.time + _fireRate;
	}
}
