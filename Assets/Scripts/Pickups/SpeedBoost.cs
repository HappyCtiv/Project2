using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{   
    [SerializeField] float timer;
    [SerializeField] float Speedboost = 2f;
    private float SpeedDecrease;

    void Start()
    {
        SpeedDecrease = 1/Speedboost;
    }

    void Update()
    {
        if (timer <=5)
        {
            timer -= Time.deltaTime;
        } 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        timer = 5f;
            if (timer > 0f)
            {
                FindObjectOfType<PlaerMovementScript>().SpeedMultipl(Speedboost);
                Debug.Log("Activating Speeeeeeed");
            }
        Destroy(gameObject);
        }
        
    }
}
