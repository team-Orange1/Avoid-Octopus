using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//シーン遷移
		if (newPlayerHp.healthPoint <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
		//ゴールしたらシーン切り替え
//		else if (TimeScript.time <= 0) {
//			SceneManager.LoadScene ("");
//		}
	}

}
