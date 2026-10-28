using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float Jump = 0f;

    public GameObject Camera;


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
            Debug.Log("Jump");
            Jump = 5f;
        }
        else
        {
            Jump = 0f;
        }

        MyInput();
        /*
        if (Input.GetKey(KeyCode.RightArrow))
        {
            HorizontalVelocity = 1f;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            HorizontalVelocity = -1f;
        }
        else
        {
            HorizontalVelocity = 0f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            VercticalVelocity = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            VercticalVelocity = -1f;
        }
        else
        {           
            VercticalVelocity = 0f;
        }
        

        rb.linearVelocity = new Vector3(Camera.transform.forward.x * HorizontalVelocity, rb.linearVelocity.y, Camera.transform.right.z * VercticalVelocity);
        */

        rb.AddForce(new Vector3(0,Jump), ForceMode.Force);
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
}
