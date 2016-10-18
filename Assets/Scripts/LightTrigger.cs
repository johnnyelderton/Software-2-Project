using UnityEngine;
using System.Collections;

public class LightTrigger : MonoBehaviour {
    private Light light;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
        light.enabled = false;
	}

    // Update is called once per frame
    void Update(){

    }
        

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            light.enabled = true;
        }
    }

    private void OnTriggerExit()
    {
        light.enabled = false;
    }
}
