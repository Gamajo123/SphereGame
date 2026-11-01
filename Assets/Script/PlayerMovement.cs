using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float Jump = 0f;

    public GameObject Camera;
    bool CanJump = true;


    public Transform orientation;
    float HInput;
    float VInput;
    Vector3 movedirection;

    [SerializeField] private float speed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Jump = 50f;
        }
        else
        {
            Jump = 0f;
        }

        MyInput();
        
        if (CanJump)
        {
            rb.AddForce(new Vector3(0, Jump), ForceMode.Force);
        }
        
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput() 
    {
        HInput = Input.GetAxis("Horizontal");
        VInput = Input.GetAxis("Vertical");
    }

    private void MovePlayer()
    {
        movedirection = orientation.forward * VInput + orientation.right * HInput;

        rb.AddForce(movedirection.normalized * speed * 6.5f, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        CanJump TouchGround = other.gameObject.GetComponent<CanJump>();

        Debug.Log(CanJump);

        if (TouchGround)
        {
            CanJump = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(CanJump);

        CanJump TouchGround = other.gameObject.GetComponent<CanJump>();

        CanJump = false;

    }
}
