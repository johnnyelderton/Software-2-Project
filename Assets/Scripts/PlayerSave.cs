using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerSave : MonoBehaviour {

	// Use this for initialization
	static float xLocation;	
	static float yLocation;	
	static float zLocation;	
	 
	static float xRotation;	static float zRotation;
	static float yRotation;	static float wRotation;

	static string scene;

	static bool lightPart;	static bool waterPart;
	static bool stealthPart;	static bool gravityPart;

	static bool hasSaved = false; 
 
	static public float getXLocation(){
		return xLocation;
	}

	static public float getYLocation(){
		return yLocation;
	}

	static public float getZLocation(){
		return zLocation;
	}

	static public float getXRotation(){
		return xRotation;
	}

	static public float getYRotation(){
		return yRotation;
	}

	static public float getZRotation(){
		return zRotation;
	}

	static public float getWRotation(){
		return wRotation; 
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

	static public string getScene(){
		return scene;
	}

	static public bool getHasSaved(){
		return hasSaved;
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

	static public void sendXRotation(float x){
		xRotation = x;
	}

	static public void sendYRotation(float y){
		yRotation = y;
	}
		
	static public void sendZRotation(float z){
		zRotation = z; 
	}

	static public void sendWRotation(float w){
		wRotation = w; 
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

	static public void sendScene(string s){
		scene = s;
	}

	static public void sendHasSaved(bool check){
		hasSaved = check;
	}
}
