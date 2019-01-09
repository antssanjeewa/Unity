using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour {

	public void Play(){
		SceneManager.LoadScene(5);
	}
	
	public void TrackSelect(){
		SceneManager.LoadScene(1);
	}
	
	public void MainMenu(){
		SceneManager.LoadScene(0);
	}
	
	public void Track01(){
		SceneManager.LoadScene(2);
	}
	
	public void Credit(){
		SceneManager.LoadScene(3);
	}
	
	public void Exit(){
		Application.Quit();
	}
	
}
