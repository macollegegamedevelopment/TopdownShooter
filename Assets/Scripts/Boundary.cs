using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour 
{
	public Vector3 Size;

	void OnDrawGizmos()
	{
		Gizmos.DrawWireCube (transform.position, Size);
	}
}
