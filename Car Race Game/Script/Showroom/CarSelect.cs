using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelect : MonoBehaviour {

	public static int CarNumber;
	
	public GameObject[] cars;
	public GameObject nameUI;
	public GameObject speedUI;
	public GameObject typeUI;
	public GameObject Unlocker;
	public GameObject PriceUI;
	public GameObject nextButton;
	
	public string[] name;
	public string[] type;
	public string[] speed;
	public int[] price;
	
	public int buynumber;
	public int CashValue;
	void Start () {
		//CashValue = GlobalCash.TotalCash;
		CashValue = PlayerPrefs.GetInt("SavedCash");
		buynumber = PlayerPrefs.GetInt("Carbuy");
	}
	
	public void LArrow(){
		cars[CarNumber].SetActive(false);
		if(CarNumber == 0){
			CarNumber = 4;
		}else{
			CarNumber -=1;
		}
		
		valueChange();
	}
	
	public void RArrow(){
		cars[CarNumber].SetActive(false);
		if(CarNumber == 4){
			CarNumber = 0;
		}else{
			CarNumber +=1;
		}
		valueChange();
	}
	
	void valueChange(){
		cars[CarNumber].SetActive(true);
		nameUI.GetComponent<Text>().text = name[CarNumber];
		speedUI.GetComponent<Text>().text = speed[CarNumber];
		typeUI.GetComponent<Text>().text = type[CarNumber];
		PriceUI.GetComponent<Text>().text = "Unlock" + price[CarNumber] + "$";
		
		if(CarNumber <= buynumber){
			Unlocker.SetActive(false);
			nextButton.GetComponent<Button>().interactable = true;
		}else{
			Unlocker.SetActive(true);
			nextButton.GetComponent<Button>().interactable = false;
		}
		
		if(CashValue >= price[CarNumber]){
			Unlocker.GetComponent<Button>().interactable = true;
		}else{
			Unlocker.GetComponent<Button>().interactable = false;
		}
	}
	
	public void Unlock(GameObject button){
		button.SetActive(false);
		nextButton.GetComponent<Button>().interactable = true;
		CashValue -= price[CarNumber];
		GlobalCash.TotalCash -= price[CarNumber];
		PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
		buynumber += 1;
		PlayerPrefs.SetInt("Carbuy",buynumber);
	}
}
