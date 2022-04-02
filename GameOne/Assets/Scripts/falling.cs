using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    public float timeForFalling;
    private TargetJoint2D target;
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player"){
            Invoke("FallingObject", timeForFalling);
        }
    }

    private void FallingObject(){
        target.enabled = false;
    }
}
