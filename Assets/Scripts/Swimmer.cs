using UnityEngine;
using System.Collections;

public class Swimmer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        RenderSettings.fog = false;
        RenderSettings.fogColor = new Color(0.2f, 0.4f, 0.8f, 0.5f);
        RenderSettings.fogDensity = 0.09f;
	}
	
    bool isUnderWater()
    {
        return gameObject.transform.position.y < 4.5f;
    }

	// Update is called once per frame
	void Update () {
        RenderSettings.fog = isUnderWater();
	}
}
