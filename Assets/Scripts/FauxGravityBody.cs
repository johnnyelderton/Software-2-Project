using UnityEngine;
using System.Collections;

public class FauxGravityBody : MonoBehaviour {

    public FauxGravityAttractor attractors1;
    public FauxGravityAttractor attractors2;
    public FauxGravityAttractor attractors3;
    public FauxGravityAttractor attractors4;
    public FauxGravityAttractor attractors5;
    public FauxGravityAttractor attractors6;
    private Transform myTransform;
    
    private Rigidbody player;
    private int Faux = 0;

    // Use this for initialization
    void Start () {
        player = GetComponent<Rigidbody>();
        player.constraints = RigidbodyConstraints.FreezeRotation;
        
        myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        switch(Faux)
        {
            case 1: 
                attractors1.Attract(myTransform);
                break;
            case 2:
                attractors2.Attract(myTransform);
                break;
            case 3:
                attractors3.Attract(myTransform);
                break;
            case 4:
                attractors4.Attract(myTransform);
                break;
            case 5:
                attractors5.Attract(myTransform);
                break;
            case 6:
                attractors6.Attract(myTransform);
                break;
            default:
                break;

        }
	}

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "FauxGravity1")
        {
            Faux = 1;
        }
        else if (coll.gameObject.tag == "FauxGravity2")
        {
            Faux = 2;
        }
        else if (coll.gameObject.tag == "FauxGravity3")
        {
            Faux = 3;
        }
        else if (coll.gameObject.tag == "FauxGravity4")
        {
            Faux = 4;
        }
        else if (coll.gameObject.tag == "FauxGravity5")
        {
            Faux = 5;
        }
        else if (coll.gameObject.tag == "FauxGravity6")
        {
            Faux = 6;
        }
    }

    private void OnTriggerExit()
    {
        Faux = 0;

    }
}
