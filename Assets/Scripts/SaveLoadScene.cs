using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoadScene : MonoBehaviour
{
    int nivel;

    public void GuardarNivel1()
    {
        nivel = 1;
        PlayerPrefs.SetInt("Nivel", nivel);
    }

    public void GuardarNivel2()
    {
        nivel = 2;
        PlayerPrefs.SetInt("Nivel", nivel);
    }

    public void GuardarNivel3()
    {
        nivel = 3;
        PlayerPrefs.SetInt("Nivel", nivel);
    }

    public void CargarNivel()
    {
        nivel = PlayerPrefs.GetInt("Nivel");

        if(nivel == 1)
        {
        SceneManager.LoadScene("Main");
        }

        if(nivel == 2)
        {
        SceneManager.LoadScene("Level2");
        }

        if(nivel == 3)
        {
        SceneManager.LoadScene("Level3");
        }
    }
}
