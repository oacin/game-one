using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{

    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public AudioSource collect_sound;


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

            collect_sound.Play();
            StartCoroutine(DestroyObjectAfter(3));

            GameController.instance.TotalScore += Score;

            GameController.instance.UpdateScoreText();        
        }
    }

    IEnumerator DestroyObjectAfter(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject, 0.3f);
    }
}
