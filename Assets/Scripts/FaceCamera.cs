using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{

	public Transform cam;

	void LateUpdate() // need to take this out and put on just the heathbar and talk bubble

	{
		transform.LookAt(transform.position + cam.forward);
	}
}
