using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        gameObject.SetActive(false);
        Invocar();
	}	

    void OnTriggerEnter(Collider cura)
    {
        if (cura.CompareTag("Player"))
        {
            Desaparece();
        }
    }

    void Update()
    {
        transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);
    }

    void Desaparece()
    {
        gameObject.SetActive(false);
        Invocar();
    }

    void Invocar()
    {
        Invoke("Reaparecer", 15.0f);
    }

    void Reaparecer()
    {
        int ubicacionX = Random.Range(-5, 6);
        int ubicacionY = Random.Range(-2, 3);
        transform.position = new Vector3(ubicacionX, ubicacionY, 0);
        gameObject.SetActive(true);
    }
} 


