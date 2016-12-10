using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class InventoryTrigger : MonoBehaviour {

	bool wireBundle; // part in the water temple
	bool autonomicRT; // part in the gravity temple
	bool booster;	// part in the light temple
	bool warpCore; // part in the stealth temple

	bool temp;
	public string scene;

	//public static GameObject shipPart; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scene = SceneManager.GetActiveScene ().name; 
			
	}

	public void OnTriggerEnter (Collider other){
		print ("Object has been triggered");

		if (scene == "Water Temple") {
			wireBundle = true;
			temp = PlayerSave.getWaterPart (); 
			if (temp == false) {
				PlayerSave.sendWaterPart (wireBundle);
			}
			print (PlayerSave.getWaterPart ()); 
		} 

		else if (scene == "Gravity Temp") {
			autonomicRT = true;
			temp = PlayerSave.getGravityPart (); 
			if (temp == false) {
				PlayerSave.sendGravityPart (autonomicRT);
			}
		} 

		else if (scene == "Stealth Temple") {
			warpCore = true;
			temp = PlayerSave.getStealthPart (); 
			if (temp == false) {
				PlayerSave.sendStealthPart (warpCore);
			}
		} 

		else if (scene == "Light Temple") {
			booster = true;
			temp = PlayerSave.getLightPart (); 
			if (temp == false) {
				PlayerSave.sendLightPart (booster);
			}
		} 

		else {
			print ("There is an error with the scene"); 
		}

	}
}
