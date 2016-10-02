using UnityEngine;
using System.Collections;
public class PauseGame : MonoBehaviour {

	public GameObject pause;

	void Start(){
		Time.timeScale = 1;
	}

	public void Update (){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(Time.timeScale == 0){
				Time.timeScale = 1;
				pause.gameObject.SetActive (false);
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked;
			} else {
				pause.gameObject.SetActive (true);
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
				Time.timeScale = 0;
			}
		}
	}
}
