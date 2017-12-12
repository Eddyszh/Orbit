using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

   	//Destruye los clones de los proyectiles.
	void Start ()
    {
        Destroy(gameObject, 2);
	}
	
	void OnTriggerEnter(Collider impacto)
    {
        if(impacto.CompareTag("Enemy"))
        Destroy(gameObject);
    }
}
