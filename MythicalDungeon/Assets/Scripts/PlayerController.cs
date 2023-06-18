
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour

{
    public float speedMove;
    private Vector3 moveVector;
    private float gravityForce;
    private CharacterController ch_controller;
    private Animator ch_animator;
    public FixedJoystick joystick;

    void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        ch_animator = GetComponent<Animator>();
    }

    void Update()
    {
        GamingGraviry();
        CharecterMove();
    }
  
    private void CharecterMove()
    {
        moveVector = Vector3.zero;
        moveVector.y = 0.00001f;
        moveVector.x = joystick.Direction.x * speedMove * Time.deltaTime;
        moveVector.z = joystick.Direction.y * speedMove * Time.deltaTime;


        if (moveVector.x != 0 || moveVector.z != 0) ch_animator.SetBool("Move", true);
        else ch_animator.SetBool("Move",false);

        if(joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(moveVector);
        }
        moveVector.y = gravityForce;
        ch_controller.Move(moveVector * Time.deltaTime);

        
    }
     private void GamingGraviry()
    {
        if (!ch_controller.isGrounded) gravityForce -= 20f * Time.deltaTime;
        else gravityForce = -1f;
    }
}