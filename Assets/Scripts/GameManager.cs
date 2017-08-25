using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
	public int holeCount;
	public Text timeTexts;
	private float score;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeTexts.text = "Time : "+Time.time;
		scoreText.text = "Score : " + score;
		if (Time.time >= 60)
			SceneManager.LoadScene ("Garden1");
	}

	public void IncScore(){
		score++;
	}

	//z <-2  x =7.5 a -7.5
	// z < 0 x = -9.5 a 9.5
	//z < 2 x = 11 a -11
	//z < 4 x  -14 a 14
	//z >5 x 16.5 a -16.5
	void HoleSpawner(){
	}

}
