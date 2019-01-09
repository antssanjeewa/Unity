using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YelloScore : MonoBehaviour {

	
	void OnTriggerEnter(){
		AsignMode.CurrentScore += 100;
		gameObject.SetActive(false);
	}
}
