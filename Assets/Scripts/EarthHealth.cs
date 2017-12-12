using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthHealth : MonoBehaviour {

    private float saludTierra = 5f;
    private float saludTotal;
    public Slider slider;
    public GUIText invasores;

    public StopGame stop;

	// Use this for initialization
	void Start ()
    {
        saludTotal = saludTierra;
        SaludTierra();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SaludTierra()
    {
        slider.value = saludTotal;
        if(saludTotal < 0)
        {
            saludTotal = 0;
        }
        invasores.text = "Invasores: " + saludTotal.ToString();
    }

    void OnTriggerEnter(Collider invasor)
    {
        if(invasor.CompareTag("Enemy"))
        {
            saludTotal -= 1f;
            SaludTierra();
        }

        if(saludTotal <= 0)
        {
            stop.GameOver();            
        }
    }

}
