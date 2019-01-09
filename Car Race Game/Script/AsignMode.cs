using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsignMode : MonoBehaviour {

	public static int CurrentScore;
	public int InternalScore;
	public int ModeSelection;
	
	public GameObject RaceUI;
	public GameObject ScoreUI;
	public GameObject TimeUI;
	public GameObject AICar;
	public GameObject ScoreValue;
	public GameObject ScoreObjects;
	public GameObject Minimap;
	
	
	void Start () {
		ModeSelection = ModeButtonclick.GameMode;
		
		if(ModeSelection == 2){
			RaceUI.SetActive(false);
			ScoreUI.SetActive(true);
			TimeUI.SetActive(false);
			AICar.SetActive(false);
			ScoreObjects.SetActive(true);
			Minimap.SetActive(false);
		}
		if(ModeSelection == 1){
			RaceUI.SetActive(false);
			ScoreUI.SetActive(false);
			TimeUI.SetActive(true);
			AICar.SetActive(false);
			ScoreObjects.SetActive(false);
			Minimap.SetActive(false);
		}
		if(ModeSelection == 0){
			RaceUI.SetActive(true);
			ScoreUI.SetActive(false);
			TimeUI.SetActive(false);
			AICar.SetActive(true);
			ScoreObjects.SetActive(false);
			Minimap.SetActive(true);
		}
	}
	
	void Update () {
		if(ModeSelection == 2){
			InternalScore = CurrentScore;
			ScoreValue.GetComponent<Text>().text = ""+InternalScore;
		}
	}
}
