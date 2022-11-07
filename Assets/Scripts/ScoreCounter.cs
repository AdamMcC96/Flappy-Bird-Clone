using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int score;
    public static int highScore;
    Text scoreText;

    public Text panelScore;
    public Text panelHighScore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
        panelScore.text = score.ToString();
        highScore = PlayerPrefs.GetInt("highscore");
        
    }

    public void Scored()
    { 
        score++;
        scoreText.text = score.ToString();
        panelScore.text = score.ToString();
        panelHighScore.text = highScore.ToString();
        if (score > highScore)
        {
            highScore = score;
            panelHighScore.text = highScore.ToString();
            PlayerPrefs.SetInt("highscore", highScore);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Text>().text = score.ToString();
    }
}
