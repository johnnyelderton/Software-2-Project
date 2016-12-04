using System;
using UnityEngine;
using UnityEngine.UI;
using Scripts;  

public class Saving : MonoBehaviour{

	public Button save;
	public GameObject FPS; 
	public float xLocation;
	public float yLocation;
	public float zLocation;
	public string scene; 
	PlayerSave saveObject; 

	public void onSaveClick (){
		xLocation = FPS.transform.position.x;   
		yLocation = FPS.transform.position.y;
		zLocation = FPS.transform.position.z; 
		scene = Application.loadedLevelName; 

		saveObject.sendXLocation (xLocation);
		saveObject.sendYLocation (yLocation);
		saveObject.sendZLocation (zLocation);
		saveObject.sendScene (scene); 

	}
}

