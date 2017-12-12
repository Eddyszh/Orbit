using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    /*public AudioClip mainMusic;
    public AudioClip levelMusic;*/    
    AudioSource music;
    public Slider slider;

	// Use this for initialization
	void Start ()
    {
        music = GetComponent<AudioSource>();
        //music.volume = PlayerPrefs.GetFloat("volume",music.volume);
	}

    void Awake()
    {
        CargarVolumen();
    }

    /*public void ActivarMusica(string mClip)
    {
        string musica = mClip;

        switch(musica)
        {
            case "MenuPrincipal":
                music.PlayOneShot(mainMusic);
                break;
            case "MusicaNivel":
                music.PlayOneShot(levelMusic);
                break;
            default:
                Debug.Log("No hay musica");
                break;
        }
    }*/

    public void Volumen()
    {
        float volumen = music.volume;
        PlayerPrefs.SetFloat("music", volumen);        
        Debug.Log("Si guarda!");
    }

    public void CargarVolumen()
    {
        //music.volume = PlayerPrefs.GetFloat("music");
        //slider.value = music.volume;
        Debug.Log("Si carga!");
    }
}
