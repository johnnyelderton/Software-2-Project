using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class cube_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter()
    {
        // Go to water temple
        SceneManager.LoadScene("Water Temple");
    }
}
