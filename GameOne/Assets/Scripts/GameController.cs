using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int TotalScore;
    public Text scoreText;
    public Text scoreTextFinal;

    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText(){
        scoreText.text = TotalScore.ToString();
        //scoreTextFinal.text = TotalScore.ToString();
    }


}
