using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image imagenPausa;
    public Image imagenOpciones;  
    public Image imagenAyuda;
    public Button botonPausa; 

    public GUIText scoreText;
    public int score;
    public HighScore highScore;
    public Leaderboard leaderboard;

    public InputField playerName;
    public Button botonAceptar;

    void Awake()
    {        
        imagenPausa.gameObject.SetActive(false);
        imagenOpciones.gameObject.SetActive(false);
        imagenAyuda.gameObject.SetActive(false);       
    }

    void Start()
    {
        //ReiniciarPuntaje();        
        score = PlayerPrefs.GetInt("score", 0); 
        UpdateScore();        
    }
    
    //Pausar el juego y entrar en el menú
    public void Pausar()
    {
        if (Time.timeScale == 1.0F)
        {
            Time.timeScale = 0.0F;
            imagenPausa.gameObject.SetActive(true);     //Activa el menú de pausa y desactiva el botón de pausa.
            botonPausa.gameObject.SetActive(false);
        }
        else
        { 
            Time.timeScale = 1.0F;
            imagenPausa.gameObject.SetActive(false);    //Desactiva la imagen de menú de pausa y vuelve activar el botoón de pausa.
            botonPausa.gameObject.SetActive(true);
        }
       
    }

    //Volver al menú principal desde el menú de pausa
    public void VolverMenuP(string volverMenu)
    {
        SceneManager.LoadScene(volverMenu);     //Sale del juego desde el menú de pausa al menú principal.
        Time.timeScale = 1.0F;
    }

    //Desde la pantalla de pausa, ingresa al menú de opciones. 
    public void Opciones()
    {
        imagenPausa.gameObject.SetActive(false);        //Activa la imagen de menú de opciones y desactiva la imagen de menú de pausa.
        imagenOpciones.gameObject.SetActive(true);
    }

    //Volver al menú de pausa desde el menú de opciones
    public void VolverOpciones()
    {
        imagenPausa.gameObject.SetActive(true);         //Activa la imagen de menú de pausa y desactiva la imagen de menú de opciones.
        imagenOpciones.gameObject.SetActive(false);        
    }    

    //Ingresar al menú de ayuda
    public void AyudaMenu()
    {
        imagenAyuda.gameObject.SetActive(true);     //Activa la imagen de menú de ayuda y desactiva la imagen de menú de pausa.
        imagenPausa.gameObject.SetActive(false);
    }

    public void VolverAyuda()
    {
        imagenAyuda.gameObject.SetActive(false);    //Activa la imagen de menú de pausa y desactiva la imagen de menú de ayuda.
        imagenPausa.gameObject.SetActive(true);
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
        highScore.Puntaje();
        PlayerPrefs.SetInt("score", score);
    }

    public void NombreJugador()
    {
        leaderboard.VerificarPuntajes(score, playerName.text);
        botonAceptar.gameObject.SetActive(false);
        playerName.gameObject.SetActive(false);
        
    }

    public void ReiniciarPuntaje()
    {
        PlayerPrefs.DeleteKey("score");
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}
