using UnityEngine;
using System.Collections;

public class FauxGravityBody : MonoBehaviour {

    public FauxGravityAttractor attractors;
    private Transform myTransform;
    
    private Rigidbody player;
    private bool FauxTrigger = false;

    // Use this for initialization
    void Start () {
        player = GetComponent<Rigidbody>();
        player.constraints = RigidbodyConstraints.FreezeRotation;
        
        myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (FauxTrigger == true)
        {
            attractors.Attract(myTransform);
        }
	}

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "FauxGravity")
        {
            FauxTrigger = true;
        }
    }

    private void OnTriggerExit()
    {
        FauxTrigger = false;

    }
}
