using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour {

	public GameObject MenuButton;
	public GameObject ClickMsg;
	public GameObject ClickButton;
	
	public void ClickMe(){
		ClickMsg.SetActive(false);
		ClickButton.SetActive(false);
		MenuButton.SetActive(true);
	}
}
