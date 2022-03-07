using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActivasionPick : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        EnemyAI activateEnemy = FindObjectOfType<EnemyAI>();

        if (other.gameObject.tag == "Player")
        {
            activateEnemy.RelicPicked = true;
            Destroy(gameObject);
        }

    }
}
