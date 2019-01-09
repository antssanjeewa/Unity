using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour {

	public int MinCount;
	public int SecCount;
	public float MiliCount;
	public GameObject MinDisplay;
	public GameObject SecDisplay;
	public GameObject MiliDisplay;
	
	void Start () {
		MinCount = PlayerPrefs.GetInt("MinSave");
		SecCount = PlayerPrefs.GetInt("SecSave");
		MiliCount = PlayerPrefs.GetFloat("MilliSave");
		
		MinDisplay.GetComponent<Text>().text = ""+MinCount+":";
		SecDisplay.GetComponent<Text>().text = ""+SecCount+".";
		MiliDisplay.GetComponent<Text>().text = ""+MiliCount+" ";
	}
}
