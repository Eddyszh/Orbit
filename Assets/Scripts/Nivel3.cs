using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nivel3 : MonoBehaviour {

    public Image round3;

    public Transform boss;
    public float spawnWaves;
    public Transform enemy;
    public Transform enemy2;
    public float wait;
    public float start;
    public int cantidadEnemigos;

    public Slider slider;
    public GUIText porcentajeSalud;


    // Use this for initialization
    void Start ()
    {
        StartCoroutine(Jefe());
        StartCoroutine(Enemigos());
        slider.gameObject.SetActive(false);
        porcentajeSalud.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.timeSinceLevelLoad >= 3)
        {
            round3.gameObject.SetActive(false);
        }       
    }

    IEnumerator Jefe()
    {       
        yield return new WaitForSeconds(40);
        Instantiate(boss, new Vector3( 0, 0, 37), Quaternion.identity);
        slider.gameObject.SetActive(true);
        porcentajeSalud.gameObject.SetActive(true);
        StopCoroutine(Jefe());
    }

    IEnumerator Enemigos()
    {
        while (Time.timeSinceLevelLoad <= 30)
        {
            yield return new WaitForSeconds(start);
            for (int i = 0; i < cantidadEnemigos; i++)
            {
                int ubicacionX = Random.Range(-5, 6);
                int ubicacionY = Random.Range(-2, 3);
                int ubicacionX2 = Random.Range(-5, 6);
                int ubicacionY2 = Random.Range(-2, 3);
                Instantiate(enemy, new Vector3(ubicacionX, ubicacionY, 35), Quaternion.identity);
                yield return new WaitForSeconds(spawnWaves);
                Instantiate(enemy2, new Vector3(ubicacionX2, ubicacionY2, 37), Quaternion.identity);
            }
            yield return new WaitForSeconds(wait);
        }
    }
}
