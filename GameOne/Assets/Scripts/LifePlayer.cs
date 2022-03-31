using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LifePlayer : MonoBehaviour
{
    //Setando a quantidade de vida que o player vai ter
    public float lifeMax;
    
    //Quantidade de vida atual
    public float lifePlay;

    public GameObject gameOver;

    public static bool isAlive = true;



    void Start()
    {
        //Ao iniciar colocando a vida do player como maxima
        lifePlay = lifeMax;
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//Função para tomar dano(Quantidade de dano passada pela Trap)
    public void takeDamage(int DamageSuffered){
        lifePlay -= DamageSuffered;


//Caso a vida chegue a 0 = Game Over
        if(lifePlay <= 0){
            gameOver.SetActive(true);
            Time.timeScale = 0;
            isAlive = false;
        }
    }

    public void restarButton(string LevelName){
        SceneManager.LoadScene(LevelName);
        Time.timeScale = 1;
    }


}
