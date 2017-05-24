using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	private GameObject player = null;
	private Vector3 offset = Vector3.zero;

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		offset = transform.position - player.transform.position;
	}

	void LateUpdate () {
		Vector3 newPosition = transform.position;
		newPosition.x = player.transform.position.x + offset.x;
		newPosition.z = player.transform.position.z + offset.z;
		transform.position = newPosition;
	}
}