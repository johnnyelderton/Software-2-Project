using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gravity_portal : MonoBehaviour
{

    void OnTriggerEnter()
    {
        // Go to gravity temple
        SceneManager.LoadScene("Gravity Temp");
    }
}
