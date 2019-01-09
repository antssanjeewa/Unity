using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour {

	public GameObject CountDown;
	public AudioSource GoAudio;
	public AudioSource GetReady;
	public AudioSource Radio;
	public GameObject LapTimer;
	public GameObject CarControls;
	public GameObject RaceFinish;
	
	void Start () {
		StartCoroutine (CountStart());
	}
	
	IEnumerator CountStart(){
		RaceFinish.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		CountDown.GetComponent<Text>().text = "3";
		GetReady.Play();
		CountDown.SetActive(true);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "2";
		GetReady.Play();
		CountDown.SetActive(true);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "1";
		GetReady.Play();
		CountDown.SetActive(true);
		yield return new WaitForSeconds(1);
		CountDown.SetActive(false);
		GoAudio.Play();
		
		CarController.m_Topspeed = 200f;
		LapTimer.SetActive(true);
		CarControls.SetActive(true);
		yield return new WaitForSeconds(1);
		Radio.Play();
	}
	
}
