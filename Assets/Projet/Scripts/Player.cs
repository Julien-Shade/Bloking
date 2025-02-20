using System.Collections;
using System.Collections.Generic;
//using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    Vector2 moveInput;
    PlayerControls controls;

    public float speed;
    public float jumpForce;


    public Transform checkPoint;
    public Transform checkPoint2;
    public Transform checkPoint3;

    
    public int actualCheckpoint;
    public Transform[] checkpoints;

    private void Awake()
    {
        controls = new PlayerControls(); //initier input system
    }

    private void OnEnable()
    {
        controls.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => moveInput = Vector2.zero;

        controls.Player.Jump.performed += ctx => rb.AddForce(0, jumpForce, 0);


        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }


    private void Start()
    {
        transform.position = checkPoint.position;

        checkpoints = new Transform[3];

        checkpoints[0] = checkPoint;
        checkpoints[1] = checkPoint2;
        checkpoints[2] = checkPoint3;

        //actualCheckpoint[0] = checkPoint;
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(moveInput.x, default, moveInput.y) * speed * Time.deltaTime);


        if (transform.position.y < 0)
        {
            transform.position = checkpoints[actualCheckpoint].position;
        }
    }
}
