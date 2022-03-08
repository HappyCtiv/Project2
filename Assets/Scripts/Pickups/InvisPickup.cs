using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<PlaerMovementScript>().isVisible = false;
            Debug.Log ("You are invisible");
            Destroy(gameObject);
        }

    }
}
