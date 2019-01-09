using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GlobalCash : MonoBehaviour {

	public int CashValue;
	public static int TotalCash;
	public GameObject CashDisplay;
	
	void Start () {
		TotalCash = PlayerPrefs.GetInt("SavedCash");
	}
	
	void Update () {
		CashValue = TotalCash;
		CashDisplay.GetComponent<Text>().text = "Cash $"+CashValue;
	}
}
