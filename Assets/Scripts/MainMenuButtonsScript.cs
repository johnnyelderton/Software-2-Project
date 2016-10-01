using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainMenuButtonsScript : MonoBehaviour {
	public void Start(){
	}

	public void Update(){
	}

	public void StartGame(){
		SceneManager.LoadScene ("Terrain");
	}

	public void Volume(Slider slider){
		AudioListener.volume = slider.value;
	}
}