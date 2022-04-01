using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{

    private SpriteRenderer sr;
    private CircleCollider2D circle;


    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();        
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            sr.enabled = false;
            circle.enabled = false;

            GameController.instance.TotalScore += Score;
            //NextLevel.instance.scoreInt += Score;

            GameController.instance.UpdateScoreText();
            
            Destroy(gameObject, 0.3f);
        }
    }
}
