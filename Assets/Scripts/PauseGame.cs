using UnityEngine;
using System.Collections;
using System.Configuration;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Assets.SwimmingSystem.Scripts;
using UnityStandardAssets.ImageEffects;

// Script that pauses the scene and shows the pause menu.
public class PauseGame : MonoBehaviour {

	public GameObject pause;    // pause menu
	public GameObject fpc;      // firstPersonController
	public GameObject grav;     // Gravity temple's main camera
	public GameObject swimBlur; // Water temple's firstPersonCharacter

	// Start the game by making sure time is not paused.
	void Start(){
		Time.timeScale = 1;
	}

	public void Update (){
		Scene currentScene = SceneManager.GetActiveScene();
		string sceneName = currentScene.name;

		// If the user presses the esc key.
		if (Input.GetKeyDown (KeyCode.Escape)) {
			
			// If the time is already paused(pause menu is shown) we want to unpause the game and hide pause menu.
			if(Time.timeScale == 0){
				Time.timeScale = 1;
				pause.gameObject.SetActive (false);
				FirstPersonController myScript = fpc.GetComponent("FirstPersonController") as FirstPersonController;
				myScript.enabled = true;
				Cursor.visible = false;
				if (sceneName == "Water Temple") {
					Blur blur = swimBlur.GetComponent ("Blur") as Blur;
					blur.enabled = true;
				}
				else if (sceneName == "Gravity Temp") {
					fpc.SetActive (true);
					HeadBob hb = grav.GetComponent ("HeadBob") as HeadBob;
					hb.enabled = true;
					GravityDirection gravity = grav.GetComponent ("GravityDirection") as GravityDirection;
					gravity.enabled = true;
					Cursor.visible = false;
				}
			}

			// If the time is not paused(pause menu is hidden) we want to pause the game and show the pause menu.
			else {
				Time.timeScale = 0;
				pause.gameObject.SetActive (true);
				FirstPersonController myScript = fpc.GetComponent("FirstPersonController") as FirstPersonController;
				myScript.enabled = false;
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
				if (sceneName == "Water Temple") {
					Blur blur = swimBlur.GetComponent ("Blur") as Blur;
					blur.enabled = false;
				}
				else if (sceneName == "Gravity Temp") {
					fpc.SetActive(false);
					HeadBob hb = grav.GetComponent("HeadBob") as HeadBob;
					hb.enabled = false;
					GravityDirection gravity = grav.GetComponent("GravityDirection") as GravityDirection;
					gravity.enabled = false;
					Cursor.visible = true;
				}
			}
		}
	}
}
