using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {

	void Start(){
	}

	public void Update (){
	}

	public void QuitGame(){
		SceneManager.LoadScene ("Main Menu");
		Time.timeScale = 1;
	}
}
