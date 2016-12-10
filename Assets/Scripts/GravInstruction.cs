using UnityEngine;
using System.Collections;

public class GravInstruction : MonoBehaviour {
	public GameObject text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider other){
			text.SetActive (true);
	}

	public void OnTriggerExit(Collider other){
			text.SetActive (false);
	}
}
