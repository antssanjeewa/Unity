using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CreditFinish : MonoBehaviour {

	void Update () {
		StartCoroutine (CreditOver());
	}
	
	IEnumerator CreditOver(){
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene(0);
		//Application.LoadLevel("MainMenu");
	}
}
