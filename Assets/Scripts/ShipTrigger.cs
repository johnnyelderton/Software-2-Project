using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ShipTrigger : MonoBehaviour {

	bool wireBundle; // part in the water temple
	bool autonomicRT; // part in the gravity temple
	bool booster;	// part in the light temple
	bool warpCore; // part in the stealth temple

	public GameObject win;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		wireBundle = PlayerSave.getWaterPart ();
		autonomicRT = PlayerSave.getGravityPart ();
		booster = PlayerSave.getLightPart ();
		warpCore = PlayerSave.getStealthPart ();

	}

	public void OnTriggerEnter (Collider other){
		// if the player has all of the ship parts
		print("Colided"); 
		if (wireBundle == true && autonomicRT == true && booster == true && warpCore == true) {
			win.SetActive (true);
			SceneManager.LoadScene ("Main Menu"); 
		}
	}
}
