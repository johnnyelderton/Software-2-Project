using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSave : MonoBehaviour {

	// Use this for initialization
	public Button load;
	public GameObject FPS; 
	public static float xLocation;
	public static float yLocation;
	public static float zLocation;
	public static string scene; 


	public void onClickLoad(){
		xLocation = PlayerSave.getXLoaction ();
		yLocation = PlayerSave.getYLoaction ();
		zLocation = PlayerSave.getZLoaction (); 
		scene = PlayerSave.getScene (); 

		SceneManager.LoadScene(scene);

		// FPS = GameObject.Find("FPSController");

		FPS = GameObject.Find("FPSContoller"); 
		Vector3 temp = new Vector3 (xLocation, yLocation, zLocation);
		FPS.transform.position += temp; 

		//FPS.transform.position.x = xLocation;
		//FPS.transform.position.y = xLocation;
		//FPS.transform.position.z = zLocation;

	}
}
