using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {

    void Start()
    {
        gameObject.SetActive(false);
        Invocar();
    }

    void OnTriggerEnter(Collider municion)
    {
        if (municion.CompareTag("Player"))
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
        Invoke("Reaparecer", 10.0f);
    }

    void Reaparecer()
    {
        int ubicacionX = Random.Range(-6, 6);
        int ubicacionY = Random.Range(-4, 5);
        transform.position = new Vector3(ubicacionX, ubicacionY, 0);
        gameObject.SetActive(true);
    }
}
