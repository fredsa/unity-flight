using UnityEngine;
using System.Collections;

public class FlightController : MonoBehaviour
{

	public float speed = .1f;
	public Transform steeringWheel;
	public GameObject ground;

	Vector2 mainTextureScale;

	void Start() {
		if (steeringWheel == null) {
			steeringWheel = Camera.main.transform;
		}
		mainTextureScale = ground.GetComponent<MeshRenderer> ().material.mainTextureScale;
	}

	void Update ()
	{
		Vector3 direction = steeringWheel.forward;
		direction.y = 0f;
		Vector3 pos = transform.position + direction * speed;
		pos.x %= mainTextureScale.x;
		pos.z %= mainTextureScale.y;
		transform.position = pos;
	}
}
