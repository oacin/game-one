using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    public float timeForFalling;
    private TargetJoint2D target;

    Vector3 startPosition;
    Quaternion startRotation;


    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        startPosition = transform.position;
        startRotation = transform.rotation;
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

    public void restartPositionFalling(){
        transform.position = startPosition;
        transform.rotation = startRotation;
        target.enabled = true;
    }
}
