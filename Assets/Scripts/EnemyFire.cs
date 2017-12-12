using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {

    public Rigidbody disparo;    
    public float delay;
    public float fireRate;	
	
	void Update ()
    {
        if (Time.time > delay && Time.timeScale == 1)
        {
            delay = Time.time + fireRate;

            Rigidbody clone;
            clone = Instantiate(disparo, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(new Vector3(0, 1, 0) * 25);            
        }
    }
}
