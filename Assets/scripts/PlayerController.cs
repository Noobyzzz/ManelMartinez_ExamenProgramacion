using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
private Rigidbody2D Rbody2D;
private InputAction MoveAction;

public Vector2 moveDirection;
public float movementSpeed = 5f;
public float jumpForce = 10f;
private InputAction jumpAction;

private GroundSensor sensor;
private SpriteRenderer render;

    void Awake()
    {
        Rbody2D = GetComponent<Rigidbody2D>();

        MoveAction = InputSystem.actions["move"];
        jumpAction = InputSystem.actions["jump"];

        sensor = GetComponentInChildren<GroundSensor>();
        render = GetComponent<SpriteRenderer>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = MoveAction.ReadValue<Vector2>();

        if(jumpAction.WasPressedThisFrame () && sensor.isGrounded)
        
        {
            Rbody2D.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);

        }
        
        if(moveDirection.x > 0)
        {
            render.flipX = false;
        }
        else if(moveDirection.x < 0)
        {
            render.flipX = true;
        }

    }

    void FixedUpdate()
    {
        Rbody2D.linearVelocity = new Vector2(moveDirection.x * movementSpeed, Rbody2D.linearVelocity.y);
    }




}

        

        


