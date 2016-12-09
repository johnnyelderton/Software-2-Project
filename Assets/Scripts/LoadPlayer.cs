using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadPlayer : MonoBehaviour {

	// Use this for initialization
	public GameObject FPS; 
	public static float xLocation;
	public static float yLocation;
	public static float zLocation; 

	 

	static public void changePosition(float xl, float yl, float zl, string scene){
		SceneManager.LoadScene (scene); 
		xLocation = xl;
		yLocation = yl; 
		zLocation = zl;

		Vector3 temp = new Vector3 (xLocation, yLocation, zLocation);
		// FPS.transform.position = temp;  

	}

}
