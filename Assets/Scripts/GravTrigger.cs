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

	private void OnTriggerEnter(Collider coll)
	{
		
		if (coll.gameObject.tag == "GravTrig" || coll.gameObject.tag == "MazeWall")
		{
			//Changes player position to GameObject
			grav.enabled = true;
		}
	}

	private void OnTriggerExit()
	{
		
		grav.enabled = false;
		Physics.gravity = new Vector3(0, -9.8F, 0);
	}
}
