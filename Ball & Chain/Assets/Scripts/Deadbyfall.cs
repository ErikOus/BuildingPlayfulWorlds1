﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deadbyfall : MonoBehaviour {

    void Update()
    {

        if (transform.position.y <= -255f)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
