using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StopGame : MonoBehaviour {
    
    private bool gameOver;
    private bool exito;

    public Image gameOverImage;
    public Image leaderboard;
    public Button pausa;
    public Image imagenExito;

    public GameManager gameManager;
	
	void Start ()
    {
        gameOver = false;
        exito = false;
        gameOverImage.gameObject.SetActive(false);
        leaderboard.gameObject.SetActive(false);
        imagenExito.gameObject.SetActive(false);
    }    

    public void GameOver()
    {
        StartCoroutine(Terminar());        
        gameOver = true;
    }

    public void Exito()
    {
        StartCoroutine(Terminar2());
        exito = true;
    }

    IEnumerator Terminar()
    {
        yield return new WaitForSeconds(3);
        if(gameOver)
        {
            gameOverImage.gameObject.SetActive(true);
            pausa.gameObject.SetActive(false);
            yield return new WaitForSeconds(2);
            Time.timeScale = 0.0F;
            leaderboard.gameObject.SetActive(true);
        }
    }

    IEnumerator Terminar2()
    {
        yield return new WaitForSeconds(3);
        if (exito)
        {
            imagenExito.gameObject.SetActive(true);
            pausa.gameObject.SetActive(false);
            yield return new WaitForSeconds(2);
            Time.timeScale = 0.0F;
            leaderboard.gameObject.SetActive(true);
        }
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0F;
        gameManager.ReiniciarPuntaje();
    }
}
