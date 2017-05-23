﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerHp.healthPoint <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
		else if (TimeScript.time <= 0) {
			SceneManager.LoadScene ("Clear");
		}
	}

}
