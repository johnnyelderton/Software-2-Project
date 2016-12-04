using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerSave : MonoBehaviour {

	// Use this for initialization
	static float xLocation;	static bool gravityPart;
	static float yLocation;	static bool stealthPart;
	static float zLocation;	static bool waterPart;
	static string scene;	static bool lightPart; 
 
	static public float getXLoaction(){
		return xLocation;
	}

	static public float getYLoaction(){
		return yLocation;
	}

	static public float getZLoaction(){
		return zLocation;
	}

	static public string getScene(){
		return scene;
	}

	static public void sendXLocation(float x){
		xLocation = x;
	}

	static public void sendYLocation(float y){
		yLocation = y; 
	}

	static public void sendZLocation(float z){
		zLocation = z; 
	}

	static public void sendScene(string s){
		scene = s;
	}

	static public void sendLightPart(bool part){
		lightPart = part; 
	}

	static public void sendWaterPart(bool part){
		waterPart = part; 
	}

	static public void sendStealthPart(bool part){
		stealthPart = part; 
	}

	static public void sendGravityPart(bool part){
		gravityPart = part; 
	}
}
