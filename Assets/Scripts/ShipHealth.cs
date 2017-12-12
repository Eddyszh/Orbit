using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipHealth : MonoBehaviour {

    public float salud = 100f;
    public Slider slider;   
    private float saludActual;    
    public StopGame stop;
    public GUIText porcentajeSalud;
    public GUIText municion;
    public LaserPoint laserPoint;
    public GameObject murio;

    public static ShipHealth shipHealth;

    void Awake()
    {
        if(shipHealth == null)
        {
            shipHealth = this;
            DontDestroyOnLoad(GameObject.FindGameObjectWithTag("Player"));
        }
        else if(shipHealth != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        saludActual = salud;
        VerificarSalud();
        VerificarMunicion();
    }

    public void VerificarSalud()
    {
        slider.value = saludActual;
        if(saludActual < 0 )
        {
            saludActual = 0;
        }
        if(saludActual >= 100)
        {
            saludActual = 100;
        }
        porcentajeSalud.text = saludActual.ToString() + " %";
    }

    public void VerificarMunicion()
    {        
        municion.text = "Ammo: " + laserPoint.totalAmmo.ToString();
    }

    void OnTriggerEnter(Collider impacto)
    {
        if (impacto.CompareTag("Enemy"))
        {
            saludActual -= 50f;
            VerificarSalud();
            Debug.Log("Salud: " + saludActual);

        }

        if (impacto.CompareTag("EnemyShot"))
        {
            saludActual -= 20f;
            VerificarSalud();
            
        }

        if (impacto.CompareTag("Ammo"))
        {
            laserPoint.Municion();
            VerificarMunicion();
        }

        if(impacto.CompareTag("Heal"))
        {
            saludActual += 30f;
            VerificarSalud();
        }     

        if (saludActual <= 0)
        {
            stop.GameOver();
            gameObject.SetActive(false);
            Instantiate(murio, transform.position, transform.rotation);
        }
    }   
}
