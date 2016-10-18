using UnityEngine;
using System.Collections;

public class FauxTrigger : MonoBehaviour {
	private FauxGravityAttractor faux;

	// Use this for initialization
	void Start () {
        faux = GetComponent<FauxGravityAttractor>();
        faux.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider coll){
		if(coll.gameObject.tag == "Player")
        {
            faux.enabled = true;
        }
			
	}

	private void OnTriggerExit(){
        faux.enabled = false;
    }


}
