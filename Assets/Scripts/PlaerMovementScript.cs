using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerMovementScript : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpForce = 2f;
    public float runSpeed = 18f;
    private float speedSave;

    private float SpeedPrevious;
    [SerializeField] float boostTimer = 5f;
    private bool boosted = false;

    public KeyCode RunKey = KeyCode.LeftShift;

    
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    
    Vector3 velocity;
    bool IsGrounded;


    void Start()
    {
        speedSave = speed;
    }

    void Update()
    {
        IsGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (IsGrounded && velocity.y <0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;     
        
        if (Input.GetKeyDown(RunKey))
        {
            speed = runSpeed;
        }
        else
        {
            speed = speedSave;
        }


        controller.Move(move * speed * Time.deltaTime);


        if (Input.GetButtonDown ("Jump") && IsGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce* -2f* gravity);
        }


        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        Debug.Log("Player speed: " + speed);

        if (boostTimer > 0.1f && boosted == true)
        {    
            boostTimer -= Time.deltaTime;
        }
        else if (boostTimer <= 0.1f)
        {
            speedSave = SpeedPrevious;
            boosted = false;
            boostTimer = 5f;
        }
    }

    public void SpeedMultipl(float speedMult)
    {
        boosted = true;
        SpeedPrevious = speedSave;
        speedSave *= speedMult;
    }
}
