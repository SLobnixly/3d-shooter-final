using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    [SerializeField] private float movespeed = 2;
    [SerializeField] private float walkingspeed = 4;
    [SerializeField] private float runningspeed = 6;

    private Vector3 movedirection;
    private Vector3 movedirectionZ;
    private Vector3 movedirectionX;
    private Vector3 movedirectionY;
    private Vector3 velocity;


    private float gravity = -18;
    private float jumpHeight = 1.2f;

    public CharacterController characterController;

    private float baselinegravity;
    private float xmove;
    private float zmove;
    private Vector3 move;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();


    }
    void Move()
    {


        float moveZ = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");

        movedirectionZ = new Vector3(0, 0, moveZ);
        movedirectionX = new Vector3(moveX, 0, 0);
        movedirection = transform.TransformDirection( movedirectionZ + movedirectionX);

        if (movedirection != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
        {
            Walk();
        }

        else if (movedirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
        {
            Run();
        }
        if(characterController.isGrounded)
        {
             if (Input.GetKey(KeyCode.Space))
           {

            Jump();
           }

             if (movedirection != Vector3.zero)
           {
            idle();
           }
        }

       







        characterController.Move(movedirection * movespeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime); 
    }
    private void Walk()
    { movedirection *= walkingspeed; }
    private void Run()
    { movedirection *= runningspeed; }
    private void Jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
    }
    private void idle()
    { }
}
