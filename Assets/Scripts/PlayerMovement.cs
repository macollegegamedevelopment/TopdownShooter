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
		Vector3 heightCorrectedPoint = new Vector3 (point.x, 
													transform.position.y, 
													point.z);
		transform.LookAt (heightCorrectedPoint);
	}
}
