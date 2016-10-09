using UnityEngine;
using UnityEngine.UI;
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

	public void Volume(Slider slider){
		AudioListener.volume = slider.value;
	}
}
