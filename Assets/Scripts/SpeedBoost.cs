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
        PlaerMovementScript target = FindObjectOfType<PlaerMovementScript>();
        if (other.gameObject.tag == "Player")
        {
        timer = 5f;
        
            if (timer > 0f)
            {
                target.SpeedMultipl(Speedboost);
                Debug.Log("Activating Speeeeeeed");
            }

            if (timer <= 0.1f)
            {
                target.SpeedMultipl(SpeedDecrease);
                Debug.Log("Minus Speed");
            }
        Destroy(gameObject);
        }
        
    }
}
