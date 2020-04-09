using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    [SerializeField]
    private float walkspeed = 12f;
    private Vector3 move;
    private Vector3 velocity;
    private CharacterController controller;
    private Animator animator;
    private float mouseX;
    private float mouseZ;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        mouseX += 0.1f * Time.deltaTime;
        mouseZ += 0.1f * Time.deltaTime;
        velocity = new Vector3(mouseX, 0f, mouseZ);
        move = transform.right * mouseX + transform.forward * mouseZ;
        velocity.y += Physics.gravity.y * Time.deltaTime;
        
        controller.Move(move * Time.deltaTime);
        controller.Move(velocity * walkspeed * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        if (velocity.magnitude > 0.1f)
        {
            animator.SetFloat("Speed", velocity.magnitude);
        }
        else
        {
            animator.SetFloat("Speed", 0f);
        }
    }
}
