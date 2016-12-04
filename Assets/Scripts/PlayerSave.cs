using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerSave : MonoBehaviour {

	// Use this for initialization
	float xLocation;
	float yLocation;
	float zLocation;
	string scene;
 
	public float getXLoaction(){
		return xLocation;
	}

	public float getYLoaction(){
		return yLocation;
	}

	public float getZLoaction(){
		return zLocation;
	}

	public string getScene(){
		return scene;
	}

	public void sendXLocation(float x){
		xLocation = x;
	}

	public void sendYLocation(float y){
		yLocation = y; 
	}

	public void sendZLocation(float z){
		zLocation = z; 
	}

	public void sendScene(string s){
		scene = s;
	}
}
