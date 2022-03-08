using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public float hitPoints = 3f;

    public void TakeDamage (float Damage)
    {
        hitPoints -= Damage;

        if (hitPoints<=0)
        {
           GetComponent<DeathHandeler>().HandleDeath();
        }
    } 
    

}
