using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public int scoreInt;
    public GameObject endLevel;

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
        }
    }

    public void nextLevel(string nextLevelName){
        SceneManager.LoadScene(nextLevelName);
        Time.timeScale = 1;
    }
}
