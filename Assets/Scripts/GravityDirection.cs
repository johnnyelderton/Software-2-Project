using UnityEngine;
using System.Collections;

public class GravityDirection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GravChange();
	}

    private void GravChange()
    {
        if(Input.GetKey (KeyCode.G))
        {

            Physics.gravity = GetComponent<Camera>().transform.forward*4;
        }
    }
}
