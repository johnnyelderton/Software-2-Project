using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class exit_script : MonoBehaviour {

    IEnumerator OnTriggerEnter()
    {
        // Go to main Terrain
        float fadeTime = GameObject.Find("ChangeLevel").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene("Terrain");
    }
}
