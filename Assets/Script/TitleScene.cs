using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//ボタンを押したら遷移
		if (Input.anyKeyDown) {
			SceneManager.LoadScene ("MainOctopus");
		}
	}
}
