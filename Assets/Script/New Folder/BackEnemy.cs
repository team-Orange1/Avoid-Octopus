using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackEnemy : MonoBehaviour {

	Rigidbody2D rb2d;
	public float scroll = 30f;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rb2d.velocity = new Vector2 (scroll, rb2d.velocity.y);
		//transform.Translate(new Vector2(scroll * Time.deltaTime, 8));
	}
}
