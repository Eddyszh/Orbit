using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
    public Rigidbody projectile;
    public int projectileSpeed;
    public float nextFire;
    public float fireDelta;
    public AudioManager audioOn;
    
    //Instanciar los proyectiles que seran disparados en modo metralladora
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire && Time.timeScale == 1)
        {
            nextFire = Time.time + fireDelta;
           
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);           

            audioOn.ActivarAudio("Bullet");

        } 

    }
}