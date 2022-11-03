using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z2L4 : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 move;
    private Vector3 velocity;
    private bool groundedPlayer;
    private float moveX;
    private float moveZ;
    public float speed;
    public float gravity = -7f;
    public float jumpHeight = 5f;

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }
    
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && velocity.y < 0)
        {
        velocity.y = 0f;
        }
        move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * Time.deltaTime * speed);
        if (Input.GetButton("Jump") && groundedPlayer)
        {
        velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
