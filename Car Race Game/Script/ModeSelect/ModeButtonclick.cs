using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModeButtonclick : MonoBehaviour {

	public static int GameMode;
	public int CashValue;
	public GameObject CashDisplay;
	
	void Start() {
		CashValue = PlayerPrefs.GetInt("SavedCash");
	}
	
	void Update() {
		CashDisplay.GetComponent<Text>().text = "Cash $"+CashValue;
	}
	
	public void Back(){
		SceneManager.LoadScene(0);
	}
	
	public void RaceMode(){
		GameMode = 0;
		SceneManager.LoadScene(4);
	}
	
	public void TimeMode(){
		GameMode = 1;
		SceneManager.LoadScene(4);
	}
	
	public void ScoreMode(){
		GameMode = 2;
		SceneManager.LoadScene(4);
	}
}
