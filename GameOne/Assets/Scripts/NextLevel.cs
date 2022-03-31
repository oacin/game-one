using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public int scoreInt;
    public GameObject endLevel;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    public static bool endGame;

    public static NextLevel instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        endGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
                endGame = true;
                endLevel.SetActive(true);
                Time.timeScale = 0;
                if(scoreInt >= 360){
                    star1.SetActive(true);
                    star2.SetActive(true);
                    star3.SetActive(true);
                }
                else if(scoreInt > 180){
                    star1.SetActive(true);
                    star2.SetActive(true);
                }
                else{
                    star1.SetActive(true);
                }

        }
    }
}
