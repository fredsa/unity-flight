using UnityEngine;
using System.Collections;

public class FlightController : MonoBehaviour
{

	public float speed = .1f;
	public Transform steeringWheel;
	public GameObject ground;

	void Start ()
	{
		transform.position = new Vector3 (0f, 1.3f * Constants.MAX_HEIGHT, 0f);
		if (steeringWheel == null) {
			steeringWheel = Camera.main.transform;
		}
	}

	void Update ()
	{
		Vector3 direction = steeringWheel.forward;
		direction.y = 0f;
		Vector3 pos = transform.position + direction * speed;
		pos.x %= Constants.GRID_SIZE;
		pos.z %= Constants.GRID_SIZE;
		transform.position = pos;
	}
}
