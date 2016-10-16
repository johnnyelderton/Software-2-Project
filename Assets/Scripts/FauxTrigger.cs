using UnityEngine;
using System.Collections;

public class FauxTrigger : MonoBehaviour {
	GameObject Planet;

	// Use this for initialization
	void Start () {
		Planet.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider coll){
		if(coll.gameObject.tag == "Player")
			Planet.SetActive (true);
	}

	private void OnTriggerExit(){
		Planet.SetActive (false);
	}


}
