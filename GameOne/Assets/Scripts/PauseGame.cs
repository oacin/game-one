using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject gamePause;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pauseGame();
    }
    public void pauseGame(){
        if(Input.GetKeyDown(KeyCode.Escape) && LifePlayer.isAlive && NextLevel.endGame == false){
            gamePause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void playButton(string LevelName){
        Time.timeScale = 1;
        gamePause.SetActive(false);
    }

    public void menuButton(){
        Time.timeScale = 1;
        SceneManager.LoadScene("SelectLevels");
    }
    
}
