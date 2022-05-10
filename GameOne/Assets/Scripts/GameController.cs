using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int TotalScore;
    public Text scoreText;
    public Text scoreTextFinal;

    public int amountStars;

    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        TotalScore = 0;
        instance = this;
        scoreText.text = TotalScore.ToString() + "/" + amountStars.ToString();
    }

    public void UpdateScoreText(){
        scoreText.text = TotalScore.ToString() + "/" + amountStars.ToString();

        //scoreTextFinal.text = TotalScore.ToString();
    }


}
