using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadInventory : MonoBehaviour {

	// Use this for initialization

	bool wireBundle; // part in the water temple
	bool autonomicRT; // part in the gravity temple
	bool booster;	// part in the light temple
	bool warpCore; // part in the stealth temple
	bool check;

	public GameObject partWater;
	public GameObject partStealth;
	public GameObject partLight;
	public GameObject partGravity;
	public GameObject menu;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		wireBundle = PlayerSave.getWaterPart ();
		autonomicRT = PlayerSave.getGravityPart ();
		booster = PlayerSave.getLightPart ();
		warpCore = PlayerSave.getStealthPart (); 
		check = menu.activeSelf; 

		if (wireBundle == true) {
			if (check == true) {
				partWater.SetActive (true);
			}
		}

		if (warpCore == true) {
			if (check == true) {
				partStealth.SetActive (true);
			}
		}

		if (booster == true) {
			if (check == true) {
				partLight.SetActive (true);
			}
		}

		if (autonomicRT == true) {
			if (check == true) {
				partGravity.SetActive (true);
			}
		}


	}


}