using UnityEngine;
using System.Collections;

public class NewEnemyDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (gameObject, 0.1F);
		}
	}
}
