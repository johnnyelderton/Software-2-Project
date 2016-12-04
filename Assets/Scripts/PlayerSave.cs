using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerSave : MonoBehaviour {

	// Use this for initialization
	float xLocation;
	float yLocation;
	float zLocation;
	string scene;

	float getXLoaction(){
		return xLocation;
	}

	float getYLoaction(){
		return yLocation;
	}

	float getZLoaction(){
		return zLocation;
	}

	string getScene(){
		return scene;
	}

	void sendXLocation(float x){
		xLocation = x;
	}

	void sendYLocation(float y){
		yLocation = y; 
	}

	void sendZLocation(float z){
		zLocation = z; 
	}

	void sendScene(string s){
		scene = s;
	}
}
