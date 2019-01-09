using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockable : MonoBehaviour {

	public GameObject RedButton;
	public int CashValue;
	
	void Update () {
		CashValue = GlobalCash.TotalCash;
		if(CashValue >= 100){
			RedButton.GetComponent<Button>().interactable = true;
		}
	}
	
	public void RedUnlock(){
		RedButton.SetActive(false);
		GlobalCash.TotalCash -= 100;
		PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
	}
}
