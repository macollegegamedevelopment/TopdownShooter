using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The PlayerMovement class moves and rotates the player
/// </summary>
public class PlayerMovement : MonoBehaviour 
{
	public void LookAt(Vector3 point)
	{
		transform.LookAt (point);
	}
}
