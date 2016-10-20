﻿using UnityEngine;
using System.Collections;

public class FauxGravityAttractor : MonoBehaviour {
    public float gravity = -10;
    private bool PlayerTrigger = false;

    public void Attract(Transform body)
    {
        Vector3 gravityUp = (body.position - transform.position).normalized;
        Vector3 bodyUp = body.up;
        if (PlayerTrigger)
        {
            body.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

            Quaternion targetRotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;
            body.rotation = Quaternion.Slerp(body.rotation, targetRotation, 50 * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            PlayerTrigger = true;
        }
    }

    private void OnTriggerExit()
    {
        PlayerTrigger = false;
    }
}
