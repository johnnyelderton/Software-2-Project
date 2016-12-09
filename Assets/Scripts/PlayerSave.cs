using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerSave : MonoBehaviour {

	// Use this for initialization
	static float xLocation;	static bool gravityPart;
	static float yLocation;	static bool stealthPart;
	static float zLocation;	static bool waterPart;
	static string scene;	static bool lightPart; 
 
	static public float getXLocation(){
		return xLocation;
	}

	static public float getYLocation(){
		return yLocation;
	}

	static public float getZLocation(){
		return zLocation;
	}

	static public string getScene(){
		return scene;
	}

	static public bool getGravityPart(){
		return gravityPart;
	}

	static public bool getStealthPart(){
		return stealthPart;
	}

	static public bool getWaterPart(){
		return waterPart;
	}

	static public bool getLightPart(){
		return lightPart;
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
