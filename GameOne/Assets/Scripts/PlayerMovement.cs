using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Definir a velocidade do player
    public float Speed;
    
    //Definir força do pulo
    public float JumpForce;

    //Buscando o Rigibody
    private Rigidbody2D rig;

    private bool inGround;
    public Transform detectGround;
    public LayerMask isGround;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float movement = Input.GetAxis("Horizontal");
        
        rig.velocity = new Vector2(movement * Speed, rig.velocity.y);

        if(movement > 0f){
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        if(movement < 0f){
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }

        if(movement != 0){
            //Andando
            animator.SetBool("isWalk", true);
        }else{
            //Parado
            animator.SetBool("isWalk", false);
        }
    }

    void Jump()
    {
        animator.SetBool("isJumping", false);
        inGround = Physics2D.OverlapCircle(detectGround.position, 0.2f, isGround);

        if(Input.GetButtonDown("Jump") && inGround)
        {
            rig.velocity = Vector2.up * 12;

            animator.SetBool("isJumping", true);
        }
    }

}