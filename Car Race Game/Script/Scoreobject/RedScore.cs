using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScore : MonoBehaviour {

	
	void OnTriggerEnter(){
		AsignMode.CurrentScore -= 50;
		gameObject.SetActive(false);
	}
}
