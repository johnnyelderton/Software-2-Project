using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadPlayer : MonoBehaviour {

	// Use this for initialization
	public static GameObject FPS; 
	public static float xLocation;
	public static float yLocation;
	public static float zLocation; 

	void Start () {
		FPS = GameObject.Find ("FPSController");
	}
	
	// Update is called once per frame
	void Update () {
		FPS = GameObject.Find ("FPSController");
		//DontDestroyOnLoad (FPS);
	}

	static public void changePosition(){
		xLocation = PlayerSave.getXLocation (); 
		yLocation = PlayerSave.getYLocation ();
		zLocation = PlayerSave.getZLocation ();

		Vector3 temp = new Vector3 (xLocation, yLocation, zLocation);
		FPS.transform.position = temp;  

	}
}
