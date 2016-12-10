using UnityEngine;
using System.Collections;

public class GravTrigger : MonoBehaviour {
	private GravityDirection grav;


	// Use this for initialization
	void Start () {
		grav = GetComponent<GravityDirection>();
		grav.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
		

	private void OnTriggerExit(Collider coll)
	{
			if (grav.enabled == false) {
				grav.enabled = true;
			} else if (grav.enabled == true) {
				grav.enabled = false;
			}
			Physics.gravity = new Vector3 (0, -9.8F, 0);

	}
}
