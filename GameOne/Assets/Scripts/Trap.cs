using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    //Criando variavel para definir quantidade de dano da armadilha
    public int DamageSuffered;

    public bool Vulnerability;

    void Start()
    {
        Vulnerability = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Quando o player colider com o trigger selecionado ele da o dano colocado la no inicio
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            if(Vulnerability == true){
                other.gameObject.GetComponent<LifePlayer>().takeDamage(DamageSuffered);
            }
        }
    }

    public void vulnerabilityIs(bool value){
        Vulnerability = value;
    }
}