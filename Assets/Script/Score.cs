using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	private int score = 0;

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = "Score: " + score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void AddPoint (int point){
		score = score + point;

		GetComponent<Text>().text = "Score: " + score.ToString();
	}
}
