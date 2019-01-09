using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraChange : MonoBehaviour {

	public GameObject NormalCam;
	public GameObject BackCam;
	public GameObject FontCam;
	public int CamMode;
	public GameObject mycar;
	
	void Update () {
		if(Input.GetButtonDown("CamView")){
			if(CamMode == 2){
				CamMode = 0;
			}else{
				CamMode +=1;
			}
			StartCoroutine(ModeChange());
		}
		if(Input.GetButtonDown("Cancel")){
			Application.Quit();
		}
		if(Input.GetButtonDown("Restart")){
			SceneManager.LoadScene(0);
		}
		if(Input.GetButtonDown("Reset")){
			mycar.transform.Rotate(0,90,0,Space.World);
		}
		if(Input.GetButtonDown("Reset2")){
			mycar.transform.Rotate(0,-90,0,Space.World);
		}
		
	}
	IEnumerator ModeChange(){
		yield return new WaitForSeconds(0.01f);
		if(CamMode == 0){
			NormalCam.SetActive(true);
			FontCam.SetActive(false);
		}
		if(CamMode == 1){
			NormalCam.SetActive(false);
			BackCam.SetActive(true);
		}
		if(CamMode == 2){
			BackCam.SetActive(false);
			FontCam.SetActive(true);
		}
	}
}
