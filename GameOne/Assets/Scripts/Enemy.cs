using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;
    public float distance;

    private bool isRight = true;

    public Transform detectGround;
    public LayerMask isGround;

    private Rigidbody2D rig;

    private bool inGround;

    public float movement = 1;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Moviment();
    }

    void Moviment(){
        inGround = Physics2D.OverlapCircle(detectGround.position, 0.2f, isGround);

        rig.velocity = new Vector2(movement * Speed, rig.velocity.y);

        if(inGround == false){
            if(isRight){
                transform.eulerAngles = new Vector3(0f,0f,0f);
                isRight = false;
                movement = -1;
            }
            else{
                transform.eulerAngles = new Vector3(0f,180f,0f);
                isRight = true;
                movement = 1;
            }
        }
    }
}
