using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {

	public GameObject MyCar;
	public GameObject AICar;
	public GameObject FinishCam;
	public GameObject ViewMode;
	public GameObject CompleteTrig;
	public GameObject FinishMsg;
	public AudioSource Music;
	
	public GameObject display;
	public GameObject place;
	
	void Start(){
		this.GetComponent<BoxCollider>().enabled = false;
		MyCar.SetActive(false);
		AICar.SetActive(false);
		FinishMsg.SetActive(true);
		CompleteTrig.SetActive(false);
		CarController.m_Topspeed = 0.0f;
		MyCar.GetComponent<CarController>().enabled = false;
		MyCar.GetComponent<CarUserControl>().enabled = false;
		MyCar.SetActive(true);
		FinishCam.SetActive(true);
		ViewMode.SetActive(false);
		Music.Play();
		GlobalCash.TotalCash += 100;
		PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
		
		if(place.GetComponent<Text>().text == "1st Place"){
			display.GetComponent<Text>().text = "Congratulation";
		}else{
			display.GetComponent<Text>().text = "Try Again";
		}
		
		StartCoroutine (BackStart());
		
	}
	
	IEnumerator BackStart(){
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene(0);
	}
}
