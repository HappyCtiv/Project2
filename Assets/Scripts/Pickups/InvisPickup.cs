using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        PlaerMovementScript target = FindObjectOfType<PlaerMovementScript>();
        if (other.gameObject.tag == "Player")
        {
            target.isVisible = false;
            Debug.Log ("You are invisible");
            Destroy(gameObject);
        }

    }
}
