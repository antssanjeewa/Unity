using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapCompleteTrig;
	
	public GameObject MinutDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;
	
	public GameObject LapTimeBox;
	
	public GameObject LapCounter;
	public int LapsDone;
	
	public float RawTime;
	
	public GameObject RaceFinish;
	
	void Update(){
		
	}
	
	void OnTriggerEnter(Collider collision){
		if(collision.gameObject.tag == "Mycar"){
			LapsDone +=1;
			RawTime = PlayerPrefs.GetFloat("RawTime");
			if(LapTimeManager.RawTime <= RawTime){
				if(LapTimeManager.Secondcount <=9){
					SecondDisplay.GetComponent<Text>().text = "0"+LapTimeManager.Secondcount+".";
				}else{
					SecondDisplay.GetComponent<Text>().text = ""+LapTimeManager.Secondcount+".";
				}
				if(LapTimeManager.Minutcount <=9){
					MinutDisplay.GetComponent<Text>().text = "0"+LapTimeManager.Minutcount+":";
				}else{
					MinutDisplay.GetComponent<Text>().text = ""+LapTimeManager.Minutcount+":";
				}
				MilliDisplay.GetComponent<Text>().text = ""+LapTimeManager.Millicount;
			}
			
			PlayerPrefs.SetInt("MinSave",LapTimeManager.Minutcount);
			PlayerPrefs.SetInt("SecSave",LapTimeManager.Secondcount);
			PlayerPrefs.SetFloat("MilliSave",LapTimeManager.Millicount);
			PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);
			
			LapTimeManager.Minutcount =0;
			LapTimeManager.Secondcount =0; 
			LapTimeManager.Millicount =0;
			LapTimeManager.RawTime = 0;
			
			LapCounter.GetComponent<Text>().text = ""+LapsDone;
			if(LapsDone == 1){
				RaceFinish.SetActive(true);
			}
			LapCompleteTrig.SetActive(false);
			HalfLapCompleteTrig.SetActive(true);
		}
	}
}
