using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemytrigger : MonoBehaviour {

    public GameObject self;

    public GameObject enemies;

    private AudioManager audioManager;

    void Start() {
        audioManager = AudioManager.instance;
        enemies.SetActive(false);
    }

    void OnTriggerEnter() {
        enemies.SetActive(true);
        audioManager.PlaySound("Enemyspawn");
        Destroy(self);
    }

}
