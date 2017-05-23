using UnityEngine;
using System.Collections;

public class BOSSInstantiate : MonoBehaviour {

	float timer = 60.0F;
	float instantiateInterval =30.0F;

	int instantiateValue;

	public GameObject Enemy;

	// Use this for initialization
	void Start () {
		//敵数
		instantiateValue = 1;
	}

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		//一定時間ごとに敵を生成する
		if(timer < 0)
		{
			if (instantiateValue > 0) {
				//敵の配置場所
				instantiateInterval -= 0.1f;
				instantiateInterval = Mathf.Clamp (instantiateInterval, 1.0f, float.MaxValue);
				Instantiate (Enemy, new Vector3 ((32.9f), (16.3f), (94.2f)), Quaternion.identity);
				instantiateValue--;
			}
			timer = instantiateInterval;
		}
	}
}