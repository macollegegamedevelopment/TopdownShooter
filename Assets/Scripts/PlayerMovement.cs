using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves and rotates the player.
/// </summary>
public class PlayerMovement : MonoBehaviour 
{
	public void LookAt(Vector3 point)
	{
		transform.LookAt (point);
	}
}
