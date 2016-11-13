using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	//Game Object you want player to teleport to
	public GameObject respawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnTriggerEnter(Collider coll)
	{
		//FirstPersonController needs to have "Player" as Tag
		if (coll.gameObject.tag == "Player")
		{
			//Changes player position to GameObject
			coll.transform.position = respawn.transform.position;
		}
	}

}
