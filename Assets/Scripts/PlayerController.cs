using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] float angleSpeed;
    [SerializeField] Camera playCamera;

    float moveX, MoveZ;
    Rigidbody rigidBody;
    Animator animator;

    bool onGround;
    bool isRunning;
    bool isJumping;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();

    }

    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        MoveZ = Input.GetAxis("Vertical");

        if(MoveZ !=0) 
        {
            animator.SetBool("isWalking", true);
        } else
        {
            animator.SetBool("isWalking", false);
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRunning = true;
            speed *= 2;            

            animator.SetBool("isRunning", isRunning);

        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRunning = false;
            speed /= 2;
            animator.SetBool("isRunning", isRunning);
        }



        if (Input.GetKeyUp(KeyCode.Space))
        {
            onGround = false;
            isJumping = true;
            animator.SetTrigger("jumped");
        }



    }

    private void FixedUpdate()
    {
        DetectGround();
        MovePlayer();   
        
    }

    void MovePlayer()
    {
        if (!onGround) return;

        rigidBody.velocity = transform.forward * MoveZ * speed;

        rigidBody.MoveRotation(rigidBody.rotation *
            Quaternion.Euler(0f, angleSpeed * moveX, 0f));

        if(isJumping)
        {
            rigidBody.AddForce(Vector3.up * speed, ForceMode.Force);
        }

    }

    void DetectGround()
    {
        RaycastHit hit;
        if(Physics.Raycast(this.transform.position, Vector3.down, out hit, 2f)) 
        {
            onGround = true;
        } else
        {
            onGround = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * 2f);        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = false;
            isJumping = false;
        }
    }






}
