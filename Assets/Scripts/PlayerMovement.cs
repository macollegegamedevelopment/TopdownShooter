using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour 
{
	[SerializeField]
	private float speed;

	private Rigidbody _rigidbody;
	private Vector3 _lookTarget;

	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody> ();
	}

	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit)) 
		{
			_lookTarget = new Vector3 (hit.point.x, transform.position.y, hit.point.z);	
		}

		transform.LookAt (_lookTarget);
	}

	public void Move(Vector3 direction)
	{
		Vector3 velocity = direction.normalized * speed * Time.fixedDeltaTime;
		_rigidbody.MovePosition (_rigidbody.position + velocity);
	}
}
