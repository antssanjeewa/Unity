using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {

	public int CashValue;
	public GameObject CashDisplay;
	
	void Start () {
		CashValue = PlayerPrefs.GetInt("SavedCash");
	}
	
	void Update () {
		CashDisplay.GetComponent<Text>().text = "Cash $"+CashValue;
	}
	
	public void Back(){
		SceneManager.LoadScene(5);
	}
	
	public void Next(){
		SceneManager.LoadScene(1);
	}
	
}
