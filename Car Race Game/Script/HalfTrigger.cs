using UnityEngine;
using System.Collections;

public class HalfTrigger : MonoBehaviour {

	public GameObject LapompleteTrig;
	public GameObject HalfCompleteTrig;
	
	
	void OnTriggerEnter(Collider collision){
		if(collision.gameObject.tag == "Mycar"){
			LapompleteTrig.SetActive(true);
			HalfCompleteTrig.SetActive(false);
		}
		
	}
}
