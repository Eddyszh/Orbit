using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nivel1 : MonoBehaviour {

    public Image round1;
    public GameManager gameManager;

    //public EstadoJuego datos;

	void Awake()
    {
        gameManager.ReiniciarPuntaje();
    }
        
	void Start ()
    {
        StartCoroutine(CargaNivel2());
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.timeSinceLevelLoad >= 3)
        {
            round1.gameObject.SetActive(false);
        }
    }

    public void Nivel2(string Level2)
    {
        //datos.Guardar();
        SceneManager.LoadScene(Level2);
    }

    IEnumerator CargaNivel2()
    {
        yield return new WaitForSeconds(40);
        Nivel2("Level2");
    }
}
