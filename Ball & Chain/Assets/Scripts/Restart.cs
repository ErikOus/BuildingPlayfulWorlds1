﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public void WhenClicked() {
        SceneManager.LoadScene("Cathedral level");
    }
}
