using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Light_entrance : MonoBehaviour {

    IEnumerator OnTriggerEnter()
    {
        // Go to light temple
        float fadeTime = GameObject.Find("ChangeLevel").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene("Light Temple");
    }
}
