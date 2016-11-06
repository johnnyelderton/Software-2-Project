using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class cube_script : MonoBehaviour {

	
    IEnumerator OnTriggerEnter()
    {
        // Go to water temple
        float fadeTime = GameObject.Find("ChangeLevel").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene("Water Temple");
    }
}
