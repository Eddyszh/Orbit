using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour {

    public float salud = 100;
    private float saludTotal;
    public Slider slider;
    public GUIText porcentajeSalud;
    public GameObject murio;
    public StopGame stopGame;
    
    
    void Start()
    {
        slider = GameObject.FindWithTag("BossSlider").GetComponent<Slider>();
        porcentajeSalud = GameObject.FindWithTag("BossHealth").GetComponent<GUIText>();
        stopGame = GameObject.FindWithTag("StopGame").GetComponent<StopGame>();
        saludTotal = salud;
        VerificarSalud();
    }

    public void VerificarSalud()
    {
        slider.value = saludTotal;
        if(saludTotal < 0)
        {
            saludTotal = 0;
        }
        if(saludTotal > 100)
        {
            saludTotal = 100;
        }
        porcentajeSalud.text = saludTotal.ToString() + " %";
    }

    void OnTriggerEnter(Collider impacto)
    {
        if(impacto.CompareTag("Laser"))
        {
            saludTotal -= 1f;
            VerificarSalud();
        }

        if(impacto.CompareTag("Bullet"))
        {
            saludTotal -= 10f;
            VerificarSalud();
        }

        if(saludTotal <= 0)
        {
            gameObject.SetActive(false);
            Instantiate(murio, transform.position, transform.rotation);
            stopGame.Exito();
        }
    }
}
