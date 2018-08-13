using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour {

    public Slider healthbar;
    public float life;
    public float MaxHealth;

    private float Health;

    void Update () {
        Health = life / MaxHealth;
        healthbar.value = Health;

        if (Health <= 0) {
            SceneManager.LoadScene("GameOver");
            
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Enemy") {
            life = life - Random.Range(2f, 3f);
        }  

    }
}
