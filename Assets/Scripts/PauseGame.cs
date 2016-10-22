using UnityEngine;
using System.Collections;
using System.Configuration;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Assets.SwimmingSystem.Scripts;
using UnityStandardAssets.ImageEffects;
public class PauseGame : MonoBehaviour {

	public GameObject pause;
	public GameObject fpc;

	void Start(){
		Time.timeScale = 1;
	}

	public void Update (){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(Time.timeScale == 0){
				Time.timeScale = 1;
				pause.gameObject.SetActive (false);
				FirstPersonController myScript = fpc.GetComponent("FirstPersonController") as FirstPersonController;
				myScript.enabled = true;
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked;
				if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Water Temple")){
					Swim swimmer = fpc.GetComponent("Swim") as Swim;
					swimmer.enabled = true;
					//Swim._blur.enabled = true;
				}
			}
			else {
				Time.timeScale = 0;
				pause.gameObject.SetActive (true);
				FirstPersonController myScript = fpc.GetComponent("FirstPersonController") as FirstPersonController;
				myScript.enabled = false;
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
				if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Water Temple")){
					Swim swimmer = fpc.GetComponent("Swim") as Swim;
					swimmer.enabled = false;
					//Swim._blur.enabled = false;
				}
			}
		}
	}
}
