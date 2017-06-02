using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class newPlayerHp : MonoBehaviour {

	public static int healthPoint;
	int healthPointMax = 1000;
	int damage = 100;
	int displayHealthPoint;
	public Text healthText;
	public Slider gaugeSlider;
	//ボイス用
	private AudioSource audioSource;
	public AudioClip sound;

	void Start () {
		healthPoint = healthPointMax;
		displayHealthPoint = healthPoint;
	//ボイス用
		audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = sound;
		audioSource.loop = false;
	}
	// Update is called once per frame
	void Update () {

		//現在の体力と表示用体力が異なっていたら現在の体力になるまで加減算する
		if (displayHealthPoint != healthPoint)
			displayHealthPoint = (int)Mathf.Lerp (displayHealthPoint, healthPoint, 0.1F);


		//体力をUI Textに表示する
		healthText.text = string.Format("{0:000} / {1:000}", displayHealthPoint, healthPointMax);

		//残り体力の割合によって文字の色を帰る
		float percentageHealthPoint = (float)displayHealthPoint / healthPointMax;

		if (percentageHealthPoint > 0.5F) {
			healthText.color = Color.white;
		} else if (percentageHealthPoint > 0.3F) {
			healthText.color = Color.yellow;
		} else {
			healthText.color = Color.red;
		}


		//ゲージの長さを体力の割合に応じて伸縮させる
		gaugeSlider.transform.localScale = new Vector3(percentageHealthPoint, 1, 1);
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
			audioSource.Play();
			healthPoint -= damage;
			healthPoint = Mathf.Clamp (healthPoint, 0, healthPointMax);
		}
//	private void OnCollisionEnter(Collision collider){
//
//		//弾に当たるとダメージ
//		if (collider.gameObject.tag == "Enemy") {
//
//			healthPoint -= damage;
//			healthPoint = Mathf.Clamp (healthPoint, 0, healthPointMax);
//		}
//	}
	}
}
