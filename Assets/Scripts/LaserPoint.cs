using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPoint : MonoBehaviour {

    public int projectileSpeed;
    public float nextFire;
    public float fireDelta;
    public Rigidbody laser;  
    public int totalAmmo;
    public AudioManager audioOn;
    ShipHealth shipHealth;

    void Start()
    {
        shipHealth = GameObject.FindWithTag("Player").GetComponent<ShipHealth>();
    }
   
    void Update ()
    {
        if (Input.GetButton("Fire2") && totalAmmo > 0 && Time.time > nextFire && Time.timeScale == 1)
        {
            nextFire = Time.time + fireDelta;
            VerMun();

            Rigidbody clone;
            clone = Instantiate(laser, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(new Vector3(0, 1, 0) * projectileSpeed);
            audioOn.ActivarAudio("Laser");
        }
    }

    public void VerMun()
    {
        totalAmmo -= 1;
        shipHealth.VerificarMunicion();
    }

    public void Municion()
    {
        totalAmmo += 10;        
    }
}
