using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shotbullet : MonoBehaviour {
	
	public GameObject detonator;
	public Text scoreGUI;
	private int point = 10;

	// Use this for initialization
	void Start () {
		//一定時間で消滅
		Destroy(gameObject, 10.0F);
	}
	
	// Update is called once per frame
	void Update () {
		//弾前進
		transform.position += transform.forward * Time.deltaTime * 8;
	}
		
	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "Player") {
			//エフェクト
			GameObject  exp = (GameObject)Instantiate (detonator.gameObject, transform.position, Quaternion.identity);
			//Playerとぶつかると消滅
			Destroy (gameObject);
		}else if (collision.collider.tag == "wall behind") {
			scoreGUI.SendMessage ("AddPoint", point);
		}
	}
}
