using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrackButtonclick : MonoBehaviour {

	public static int TrackNumber;
	
	public GameObject[] track;
	public GameObject CarnameUI;
	public GameObject LapUI;
	//public GameObject typeUI;
	public GameObject Unlocker;
	public GameObject PriceUI;
	public GameObject nextButton;
	
	public string[] Carname;
	public string[] lap;
	//public string[] speed;
	public string[] price;
	
	public int CashValue;
	public GameObject CashDisplay;
	
	void Start () {
		CashValue = PlayerPrefs.GetInt("SavedCash");
	}
	
	void Update () {
		CashDisplay.GetComponent<Text>().text = "Cash $"+CashValue;
	}
	
	public void LArrow(){
		track[TrackNumber].SetActive(false);
		if(TrackNumber == 0){
			TrackNumber = 2;
		}else{
			TrackNumber -=1;
		}
		
		valueChange();
	}
	
	public void RArrow(){
		track[TrackNumber].SetActive(false);
		if(TrackNumber == 2){
			TrackNumber = 0;
		}else{
			TrackNumber +=1;
		}
		valueChange();
	}
	
	void valueChange(){
		track[TrackNumber].SetActive(true);
		CarnameUI.GetComponent<Text>().text = Carname[TrackNumber];
		LapUI.GetComponent<Text>().text = lap[TrackNumber];
		//typeUI.GetComponent<Text>().text = type[TrackNumber];
		PriceUI.GetComponent<Text>().text = price[TrackNumber];
		
		if(TrackNumber == 0){
			Unlocker.SetActive(false);
			nextButton.GetComponent<Button>().interactable = true;
		}else{
			Unlocker.SetActive(true);
			nextButton.GetComponent<Button>().interactable = false;
		}
	}
	
	public void Back(){
		SceneManager.LoadScene(4);
	}
	
	public void Next(){
		SceneManager.LoadScene(2);
	}
}
