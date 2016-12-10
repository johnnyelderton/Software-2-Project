using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Saving : MonoBehaviour{

	public Button save;
	public GameObject FPS; 

	public float xLocation;	public float xRotation;
	public float yLocation;	public float yRotation;
	public float zLocation;	public float zRotation;
	public float wRotation; 

	public string scene;  

	public void onSaveClick (){
		xLocation = FPS.transform.position.x;   
		yLocation = FPS.transform.position.y;
		zLocation = FPS.transform.position.z;  

		xRotation = FPS.transform.rotation.x;
		yRotation = FPS.transform.rotation.y;
		zRotation = FPS.transform.rotation.z;
		wRotation = FPS.transform.rotation.w;
		//print (xRotation); 
		//print (yRotation); 
		//print (zRotation);
		//print (wRotation); 

		scene = SceneManager.GetActiveScene ().name; 

		PlayerSave.sendXLocation (xLocation);
		PlayerSave.sendYLocation (yLocation);
		PlayerSave.sendZLocation (zLocation);

		PlayerSave.sendXRotation (xRotation);
		PlayerSave.sendYRotation (yRotation);
		PlayerSave.sendZRotation (zRotation);
		PlayerSave.sendWRotation (wRotation); 

		PlayerSave.sendScene (scene); 
		PlayerSave.sendHasSaved (true); 

		// Event(); 

		SceneManager.LoadScene("Main Menu");
	}

	IEnumerator Event(){
		float fadeTime = GameObject.Find("ChangeLevel").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		SceneManager.LoadScene("Main Menu");
	}
}

