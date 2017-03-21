using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
	[SerializeField]
	private float _speed;

	[SerializeField]
	private float _lifetime;

	void Start()
	{
		Destroy (gameObject, _lifetime);
	}

	void Update()
	{
		transform.Translate (Vector3.forward * _speed * Time.deltaTime);
	}
}
