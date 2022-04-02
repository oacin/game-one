using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LifePlayer : MonoBehaviour
{
    //Setando a quantidade de vida que o player vai ter
    private int lifeMax = 3;
    
    //Quantidade de vida atual
    private int lifePlay;

    public GameObject gameOver;

    public static bool isAlive = true;

    public GameObject life_1, life_2, life_3;

    public Animator animator;

    public AudioSource dead_sound;



    void Start()
    {
        //Ao iniciar colocando a vida do player como maxima
        lifePlay = lifeMax;
        isAlive = true;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//Função para tomar dano(Quantidade de dano passada pela Trap)
    public void takeDamage(int DamageSuffered){
        lifePlay -= DamageSuffered;

        if(lifePlay == 3){
            life_1.SetActive(true);
            life_2.SetActive(true);
            life_3.SetActive(true);
        }

        else if(lifePlay == 2){
            life_1.SetActive(true);
            life_2.SetActive(true);
            life_3.SetActive(false);
        }

        else if(lifePlay == 1){
            life_1.SetActive(true);
            life_2.SetActive(false);
        }


//Caso a vida chegue a 0 = Game Over
        else{
            life_1.SetActive(false);
            life_2.SetActive(false);
            life_3.SetActive(false);

            animator.SetBool("isDead", true);

            gameOver.SetActive(true);
            dead_sound.Play();
            Time.timeScale = 0;
            isAlive = false;
        }
    }

    public void restarButton(string LevelName){
        SceneManager.LoadScene(LevelName);
        Time.timeScale = 1;
    }


}
