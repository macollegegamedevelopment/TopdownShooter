using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour 
{
	[SerializeField]
	private float _speed;

	private Rigidbody _rigidbody;

	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody> ();
		Destroy (gameObject, 2f);
	}

	void FixedUpdate()
	{
		Vector3 velocity = transform.forward * _speed * Time.fixedDeltaTime;
		_rigidbody.MovePosition (_rigidbody.position + velocity);
	}
}
