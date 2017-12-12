using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour {
    public Text[] highScores;
    int[] highScoreValues;
    string[] highScoreNames;


	// Use this for initialization
	void Start ()
    {
        highScoreValues = new int [highScores.Length];
        highScoreNames = new string[highScores.Length];

        for (int x = 0; x < highScores.Length; x++)
        {
            highScoreValues[x] = PlayerPrefs.GetInt("highScoreValues" + x);
            highScoreNames[x] = PlayerPrefs.GetString("highScoreNames" + x);
        }
        EscribirPuntaje();
	}
	
    void GuardarPuntajes()
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            PlayerPrefs.SetInt("highScoreValues" + x, highScoreValues [x]);
            PlayerPrefs.SetString("highScoreNames" + x, highScoreNames [x]);
        }
    }

    public void VerificarPuntajes(int _value, string _userName)
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            if (_value > highScoreValues [x])
            {
                for(int y = highScores.Length - 1; y > x; y--)
                {
                    highScoreValues[y] = highScoreValues[y - 1];
                    highScoreNames[y] = highScoreNames[y - 1];
                }

                highScoreValues[x] = _value;
                highScoreNames[x] = _userName;

                EscribirPuntaje();
                GuardarPuntajes();
                break;
            }
        }
    }

    void EscribirPuntaje()
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            highScores[x].text = highScoreNames[x] + " ------------------- " + highScoreValues[x].ToString();
        }
    }




	// Update is called once per frame
	void Update () {
		
	}
}
