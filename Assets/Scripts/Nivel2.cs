using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nivel2 : MonoBehaviour {

    public Image round2;

	
	void Start ()
    {
        StartCoroutine(CargaNivel3());
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.timeSinceLevelLoad >= 3)
        {
            round2.gameObject.SetActive(false);
        }
    }

    public void Nivel3(string Level3)
    {
        SceneManager.LoadScene(Level3);
    }

    IEnumerator CargaNivel3()
    {
        yield return new WaitForSeconds(40);
        Nivel3("Level3");
    }
}
