using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {

    float xMovement = Input.GetAxis("Horizontal");
    Debug.Log(xMovement);
    float yMovement = Input.GetAxis("Vertical");
    Debug.Log(yMovement);

    float xOffset = xMovement * Time.deltaTime * controlSpeed;
    float newxPos = transform.localPosition.x + xOffset;

    float yOffset = yMovement * Time.deltaTime * controlSpeed;
    float newyPos = transform.localPosition.y + yOffset;

    transform.localPosition = new Vector3 (newxPos, newyPos, transform.localPosition.z);


    }
}
