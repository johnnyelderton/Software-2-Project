using UnityEngine;
using System.Collections;

public class GravityDirection : MonoBehaviour {
	private Camera cam;

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
        GravChange();
	}

    private void GravChange()
    {
        if(Input.GetKey (KeyCode.G))
        {

            Physics.gravity = cam.transform.forward*4;
        }
    }
}
