﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticles : MonoBehaviour {

    void OnEnable()
    {
        Destroy(gameObject, 1);
    }
}