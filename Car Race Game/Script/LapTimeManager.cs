using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

	public static int Minutcount;
	public static int Secondcount;
	public static float Millicount;
	public static string Millidisplay;
	
	public GameObject Minutbox;
	public GameObject Secondbox;
	public GameObject MilliBox;
	
	public static float RawTime;
	
	void Update () {
		Millicount += Time.deltaTime * 10;
		RawTime += Time.deltaTime;
		Millidisplay = Millicount.ToString("F0");
		MilliBox.GetComponent<Text>().text = "" + Millidisplay;
		
		if(Millicount >= 10){
			Secondcount += 1;
			Millicount = 0;
			
		}
		
		if(Secondcount <= 9){
			Secondbox.GetComponent<Text>().text = "0"+Secondcount+".";
		}else{
			Secondbox.GetComponent<Text>().text = ""+Secondcount+".";
		}
		
		if(Secondcount >= 60){
			Secondcount = 0;
			Minutcount += 1;
		}
		
		if(Minutcount <= 9){
			Minutbox.GetComponent<Text>().text = "0"+Minutcount+":";
		}else{
			Minutbox.GetComponent<Text>().text = ""+Minutcount+":";
		}
	}
}
