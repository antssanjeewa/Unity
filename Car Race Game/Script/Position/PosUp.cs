using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosUp : MonoBehaviour {

	public GameObject PosDisplay;
	
	void OnTriggerExit(Collider other){
		if(other.tag == "CarPos"){
			PosDisplay.GetComponent<Text>().text = "1st Place";
		}
	}
}
