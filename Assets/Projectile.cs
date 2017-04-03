using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the projectile forward
/// </summary>
public class Projectile : MonoBehaviour 
{
	[SerializeField]
	private float _speed;
	
	private Rigidbody _rigidbody;
	private float _despawnTime = 2f;

	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody> ();
		Destroy (gameObject, _despawnTime);
	}

	void FixedUpdate()
	{
		Vector3 velocity = transform.forward * _speed * Time.fixedDeltaTime;
		_rigidbody.MovePosition (_rigidbody.position + velocity);
	}
}
