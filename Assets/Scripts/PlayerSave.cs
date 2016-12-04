using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerSave : MonoBehaviour {

	// Use this for initialization
	static float xLocation;
	static float yLocation;
	static float zLocation;
	static string scene;
 
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
}
