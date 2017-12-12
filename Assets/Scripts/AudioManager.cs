using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public AudioClip laser;
    public AudioClip bullet;
    public AudioClip cura;
    public AudioClip mejora;
    public AudioClip pausa;
    public AudioClip boton;
    public AudioClip explosion;
    AudioSource sfx;
    

    void Start()
    {
        sfx = GetComponent<AudioSource>();
    }


    public void ActivarAudio(string aClip)
    {
        string sonido = aClip;

        switch(sonido)
        {
            case "Laser":
                sfx.PlayOneShot(laser);
                break;
            case "Bullet":
                sfx.PlayOneShot(bullet);
                break;
            case "Cura":
                sfx.PlayOneShot(cura);
                break;
            case "Mejora":
                sfx.PlayOneShot(mejora);
                break;
            case "Pausa":
                sfx.PlayOneShot(pausa);
                break;
            case "Boton":
                sfx.PlayOneShot(boton);
                break;
            case "Explosion":
                sfx.PlayOneShot(explosion);
                break;
            default:
                Debug.Log("No hay audio");
                break;
        }
    }

   
}
