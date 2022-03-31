using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCommands : MonoBehaviour
{
    public void LoadScene(int indexScene){
        SceneManager.LoadScene(indexScene);
    }

    public void ExitGame(){
        Application.Quit();
    }
}
