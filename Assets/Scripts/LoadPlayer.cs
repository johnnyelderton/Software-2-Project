using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadPlayer : MonoBehaviour {

	// Use this for initialization

	// initializing the game object FPS
	public static GameObject FPS; 

	// initializing values xSaved, ySaved, and zSaved.
	// and initializing values xRSaved, yRSaved, zRSaved.
	public static float xSaved;	public static float xRSaved;
	public static float ySaved;	public static float yRSaved;
	public static float zSaved;	public static float zRSaved; 
	public static float wRSaved;

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

		// establishes the x,y, and z values of location that are saved. 
		xSaved = PlayerSave.getXLocation (); 
		ySaved = PlayerSave.getYLocation ();
		zSaved = PlayerSave.getZLocation (); 

		// establishes the x, y, z, and w values of rotation that are saved.
		xRSaved = PlayerSave.getXRotation ();
		yRSaved = PlayerSave.getYRotation ();
		zRSaved = PlayerSave.getZRotation ();
		wRSaved = PlayerSave.getWRotation ();

		// sets a new vector that is the same as the x,y and z values of location saved. 
		Vector3 saved = new Vector3 (xSaved, ySaved, zSaved);
		// sets a new quaternion that is the same as the x, y, z, and w values of rotation saved.
		Quaternion rsaved = new Quaternion (xRSaved,yRSaved, zRSaved, wRSaved);

		//print (rsaved); 

		// makes check equal to if the player has saved the game before.
		check = PlayerSave.getHasSaved ();

		// if statement that determines if there has been a save and if the values 
		// of x,y and z are not 0.
		if(check == true && (xSaved != 0 && ySaved !=0 && zSaved!=0)){
			FPS.transform.position = saved;	// makes the orientation of the player object equal to the x,y,
			// and z values stored in the save.
			FPS.transform.rotation = rsaved;  // makes the rotation of the player object equal to the x,
			// y, z, and w values stored in the save.
			PlayerSave.sendHasSaved (false); // makes has saved to false in the player save.
		}
	}
}
