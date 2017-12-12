using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    public GameManager score;

    public GUIText scoreText;
    public GUIText highScore;

    
    // Use this for initialization
    void Start ()
    {
        highScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
	}
	
    public void Puntaje()
    {
        int number = score.score;
        scoreText.text = "Score: " + number.ToString();

        if(number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = "HighScore: " + number.ToString();
        }
    }
}