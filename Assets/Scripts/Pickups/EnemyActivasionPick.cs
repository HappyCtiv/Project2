using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActivasionPick : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<EnemyAI>().RelicPicked = true;
            Destroy(gameObject);
        }

    }
}
