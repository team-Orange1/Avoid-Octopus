using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//ボタンを押したら遷移
		if (Input.anyKeyDown) {
			SceneManager.LoadScene ("Title");
		}
	}
}
