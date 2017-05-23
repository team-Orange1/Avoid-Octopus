using UnityEngine;
using System.Collections;

public class BOSS_shotbullet : MonoBehaviour {
	public GameObject detonator;
	// Use this for initialization
	void Start () {
		//一定時間で消滅
		Destroy(gameObject, 10.0F);

	}

	// Update is called once per frame
	void Update () {
		//弾前進
		transform.position += transform.forward * Time.deltaTime * 15;
	}
	bool hitFlag = false;
	void OnCollisionEnter(Collision collision) {
		//if (avater != null) {
		if (hitFlag == false && collision.collider.tag == "Player") {
			hitFlag = true;
			//エフェクト
			GameObject  exp = (GameObject)Instantiate (detonator.gameObject, transform.position, Quaternion.identity);
			//Playerとぶつかると消滅
			Destroy (gameObject);
		}
		//}
	}
}
