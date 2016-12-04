using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSave : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

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
		//FPS.transform.position.x = xLocation;
		//FPS.transform.position.y = xLocation;
		//FPS.transform.position.z = zLocation;

	}
}
