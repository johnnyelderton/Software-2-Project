using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSave : MonoBehaviour {

	public Button load;
	public GameObject FPS;
	public static float xLocation;
	public static float yLocation;
	public static float zLocation;
	public static string scene; 
	//public LoadPlayer example; 

	public void onClickLoad(){
		xLocation = PlayerSave.getXLoaction ();
		yLocation = PlayerSave.getYLoaction ();
		zLocation = PlayerSave.getZLoaction (); 
		scene = PlayerSave.getScene (); 

		SceneManager.LoadScene(scene); 

		LoadPlayer.changePosition (xLocation, yLocation, zLocation, scene); 

		//print (GameObject.Find ("FPSController"));
		//example = GameObject.Find ("FPSController").GetComponents<LoadPlayer>();
		 
		//Vector3 temp = new Vector3 (xLocation, yLocation, zLocation);
		//FPS.transform.position = temp; 

	}
}
