using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gravity_portal : MonoBehaviour
{

    IEnumerator OnTriggerEnter()
    {
        // Go to water temple
        float fadeTime = GameObject.Find("ChangeLevel").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene("Gravity Temp");
    }
}
