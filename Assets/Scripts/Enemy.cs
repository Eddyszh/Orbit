using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
   
    public GameManager score;
    public int scoreValue;

    public GameObject muerto;

    public AudioManager explosion;

    void Start()
    {    
        score = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        explosion = GameObject.FindWithTag("SFX").GetComponent<AudioManager>();
    }   
    
    void Update()
    {       
        transform.position -= Vector3.forward * speed*Time.deltaTime;       
    }
    
    void OnTriggerEnter(Collider contacto)
    {
        if (contacto.CompareTag("Laser"))
        {
            Destroy(gameObject);
            score.AddScore(scoreValue);
            Instantiate(muerto, transform.position, transform.rotation);
            explosion.ActivarAudio("Explosion");
        }

        if (contacto.CompareTag("Bullet"))
        {
            Destroy(gameObject);           
            score.AddScore(scoreValue);
            Instantiate(muerto, transform.position, transform.rotation);            
            explosion.ActivarAudio("Explosion");
        }

        if (contacto.CompareTag("Player"))
        {
            Destroy(gameObject);
            score.AddScore(scoreValue);
            Instantiate(muerto, transform.position, transform.rotation);
            explosion.ActivarAudio("Explosion");
        }

        if (contacto.CompareTag("Limite"))
        {
            Destroy(gameObject);
        }

        

    }
}
