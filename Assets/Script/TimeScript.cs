using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
	public static float time ;
	// Use this for initialization
	void Start () {
		time = 91;
		// float型からint型へcastし、string型に変換して表示
		GetComponent<Text>().text = ((int)time).ToString();
	}
	// Update is called once per frame
	void Update () {
		//1秒に1ずつ減らしていく
		time -= Time.deltaTime;
		// マイナスは表示しない
		if (time < 0) time = 0;
		GetComponent<Text> ().text = ((int)time).ToString ();
	}
}