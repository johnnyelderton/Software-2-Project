using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class stealth_portal : MonoBehaviour
{

    IEnumerator OnTriggerEnter()
    {
        // Go to stealth temple
        float fadeTime = GameObject.Find("ChangeLevel").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene("Stealth Temple");
    }
}
