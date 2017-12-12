using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2);
    }

    void OnTriggerEnter(Collider impacto)
    {
        if (impacto.CompareTag("Player"))
            Destroy(gameObject);
    }
}
