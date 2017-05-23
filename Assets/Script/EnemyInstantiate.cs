using UnityEngine;
using System.Collections;

public class EnemyInstantiate : MonoBehaviour {

	float timer = 5.0F;
	float instantiateInterval =3.0F;

	int instantiateValue;

	public GameObject Enemy;

	// Use this for initialization
	void Start () {
		//敵数
		instantiateValue = 30;
	}

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		//一定時間ごとに敵を生成する
		if(timer < 0)
		{
			if(instantiateValue > 0)
			{
				//ランダムに敵を配置
				Instantiate(Enemy,new Vector3(Random.Range(20.0f,50.0f),
					Random.Range (1.0f,8.0f),Random.Range(50.0f,60.0f)),Quaternion.identity);
				instantiateValue--;
			}
			instantiateInterval -= 0.1f;
			instantiateInterval = Mathf.Clamp (instantiateInterval, 1.0f, float.MaxValue);

			timer = instantiateInterval;
		}
	}
}