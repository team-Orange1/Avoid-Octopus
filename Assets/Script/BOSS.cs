using UnityEngine;
using System.Collections;

public class BOSS: MonoBehaviour {
	GameObject target;

	public GameObject bullet;

	float timer = 2.0F;
	float shotInterval =3.5F;

	int instantiateValue;

	// Use this for initialization
	void Start () {
		//ターゲット取得
		target = GameObject.Find("EthanTarget");

		//弾数
		instantiateValue = 17;
	}

	// Update is called once per frame
	void Update () {
		//ターゲットの方向を向く
		transform.LookAt(target.transform);

		timer -= Time.deltaTime;

		if (timer < 0) {
			if (instantiateValue > 0) {
				Instantiate (bullet, transform.position, transform.rotation);
				instantiateValue--;
			}
			shotInterval -= 0.5f;
			shotInterval = Mathf.Clamp (shotInterval, 1.0f, float.MaxValue);

			timer = shotInterval;
		}
	}
}