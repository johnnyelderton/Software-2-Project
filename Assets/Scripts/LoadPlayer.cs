using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadPlayer : MonoBehaviour {

	// Use this for initialization

	// initializing the game object FPS
	public static GameObject FPS; 

	// initializing values xSaved, ySaved, and zSaved.
	public static float xSaved;
	public static float ySaved;
	public static float zSaved;

	// initializing the boolean check.
	public static bool check;

	// initializing the string scene.
	public static string scene;

	void Start () {
		// initializes what the name of the scene is.
		scene = SceneManager.GetActiveScene ().name; 

		// sets FPS to the player controller in each scene. 
		FPS = GameObject.Find ("FPS"+scene);
	}

	// Update is called once per frame
	void Update () {
		// initializes what the name of the scene is
		scene = SceneManager.GetActiveScene ().name; 

		// sets FPS to the player controller in each scene. 
		FPS = GameObject.Find ("FPS"+scene);

		// establishes the x,y, and z values that are saved. 
		xSaved = PlayerSave.getXLocation (); 
		ySaved = PlayerSave.getYLocation ();
		zSaved = PlayerSave.getZLocation (); 

		// sets a new vector that is the same as the x,y and z values saved. 
		Vector3 saved = new Vector3 (xSaved, ySaved, zSaved);

		// makes check equal to if the player has saved the game before.
		check = PlayerSave.getHasSaved ();

		// if statement that determines if there has been a save and if the values 
		// of x,y and z are not 0.
		if(check == true && (xSaved != 0 && ySaved !=0 && zSaved!=0)){
			FPS.transform.position = saved;	// makes the orientation of the player object equal to the x,y,
			// and z values stores in the save.
			PlayerSave.sendHasSaved (false); // makes has saved to false in the player save.
		}
	}
}
