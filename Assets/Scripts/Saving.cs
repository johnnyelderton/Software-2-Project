using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Saving : MonoBehaviour{

	public Button save;
	public GameObject FPS; 
	public float xLocation;
	public float yLocation;
	public float zLocation;
	public string scene;  

	public void onSaveClick (){
		xLocation = FPS.transform.position.x;   
		yLocation = FPS.transform.position.y;
		zLocation = FPS.transform.position.z; 
		scene = Application.loadedLevelName; 

		PlayerSave.sendXLocation (xLocation);
		PlayerSave.sendYLocation (yLocation);
		PlayerSave.sendZLocation (zLocation);
		PlayerSave.sendScene (scene); 

		// Event(); 

		SceneManager.LoadScene("Main Menu");
	}

	IEnumerator Event(){
		float fadeTime = GameObject.Find("ChangeLevel").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		SceneManager.LoadScene("Main Menu");
	}
}

