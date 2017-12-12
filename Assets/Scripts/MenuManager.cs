using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

    public Image imagenMenu;
    public Image imagenOpciones;
    public Button imagenControles;
    public Button imagenSalud;
    public Button imagenMejoras;
    public Image imagenOrbit;
    public Image imagenCreditos;
    // public MusicManager music;

    public bool creditos;

    void Awake ()
    {
        imagenMenu.gameObject.SetActive(true);
        imagenOpciones.gameObject.SetActive(false);
        imagenControles.gameObject.SetActive(false);
        imagenSalud.gameObject.SetActive(false);
        imagenMejoras.gameObject.SetActive(false);
        imagenOrbit.gameObject.SetActive(false);
        imagenCreditos.gameObject.SetActive(false);
        creditos = false;
    }

    void Start()
    {
        //music.ActivarMusica("MenuPrincipal");
    }

    //Iniciar el juego desde el menú principal
    public void IniciarJuego(string iniciar)
    {
        SceneManager.LoadScene(iniciar);
        Time.timeScale = 1.0F;
    }

    //vovler al menú principal desde las opciones del menú principal.
    public void OpcionesDesMP()
    {
        imagenMenu.gameObject.SetActive(false);
        imagenOpciones.gameObject.SetActive(true);
    }

    public void VolverAMenuP()
    {
        imagenMenu.gameObject.SetActive(true);
        imagenOpciones.gameObject.SetActive(false);
    }

    public void Creditos()
    {
        imagenCreditos.gameObject.SetActive(true);
        imagenOpciones.gameObject.SetActive(false);
        creditos = true;        
    }

    void Update()
    {
        if (creditos)
        {
            if (Input.anyKeyDown)
            {
                imagenCreditos.gameObject.SetActive(false);
                imagenOpciones.gameObject.SetActive(true);
                creditos = false;
            }
        }
    }

    public void Guia(string explicar)
    {
        switch(explicar)
        {
            case "Controles":
                imagenMenu.gameObject.SetActive(false);
                imagenControles.gameObject.SetActive(true);
                break;
            case "Salud":
                imagenControles.gameObject.SetActive(false);
                imagenSalud.gameObject.SetActive(true);
                break;
            case "Mejoras":
                imagenSalud.gameObject.SetActive(false);
                imagenMejoras.gameObject.SetActive(true);
                break;
            case "Orbit":
                imagenMejoras.gameObject.SetActive(false);
                imagenOrbit.gameObject.SetActive(true);
                if (Time.timeSinceLevelLoad >= 2)
                    IniciarJuego("Main");                
                break;
        }
    }
}
