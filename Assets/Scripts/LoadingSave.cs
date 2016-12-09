using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSave : MonoBehaviour {

	public Button load;
	public static string scene; 

	public void onClickLoad(){ 
		scene = PlayerSave.getScene (); 
		SceneManager.LoadScene(scene); 
		LoadPlayer.changePosition(); 

	}
}
