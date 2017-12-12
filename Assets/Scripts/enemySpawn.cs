using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour {

    public float spawnWaves;
    public Transform enemy;   
    public float wait;
    public float start;
    public int cantidadEnemigos;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(Enemigos());
	}
	

    public IEnumerator Enemigos()
    {
        while (Time.timeSinceLevelLoad <= 30)
        {
            yield return new WaitForSeconds(start);
            for (int i = 0; i < cantidadEnemigos; i++)
            {
                int ubicacionX = Random.Range(-5, 6);
                int ubicacionY = Random.Range(-2, 3);
                Instantiate(enemy, new Vector3(ubicacionX, ubicacionY, 35), Quaternion.identity);
                yield return new WaitForSeconds(spawnWaves);
            }
            yield return new WaitForSeconds(wait);
        }
    }

}
