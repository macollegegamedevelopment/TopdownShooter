using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollower : MonoBehaviour 
{
	[SerializeField]
	private Transform _target;

	[SerializeField]
	private float _slopeSpeed;

	[SerializeField]
	private float _directionOffset;

	[SerializeField]
	private Boundary _boundary;

	private Camera _camera;
	private Vector3 _offset;

	void Awake()
	{
		_camera = GetComponent<Camera> ();
	}

	void Start()
	{
		_offset = _target.position + transform.position;
	}

	void FixedUpdate()
	{
		Vector3 targetPosition = _target.position + (_target.forward * _directionOffset) + _offset;
		targetPosition.x = Mathf.Clamp (targetPosition.x, -_boundary.Size.x / 2f + _camera.orthographicSize * _camera.aspect, _boundary.Size.x / 2f - _camera.orthographicSize * _camera.aspect);
		targetPosition.z = Mathf.Clamp (targetPosition.z, -_boundary.Size.z / 2f + _camera.orthographicSize, _boundary.Size.z / 2f - _camera.orthographicSize);
		transform.position = Vector3.Lerp(transform.position, targetPosition , _slopeSpeed * Time.deltaTime);
	}
}
