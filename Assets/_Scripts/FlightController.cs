using UnityEngine;
using System.Collections;

public class FlightController : MonoBehaviour
{

	public float speed = .1f;


	void Update ()
	{
		Vector3 pos = transform.position + transform.forward * speed;
		pos.x %= 1f;
//		pos.y %= 1f;
		pos.z %= 1f;
		transform.position = pos;
	}
}
