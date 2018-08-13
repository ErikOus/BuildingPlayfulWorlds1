using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject enemyRenderer;
    public ParticleSystem enemyParticles;
    public GameObject enemy;
    public Collider enemycollider;
    public Rigidbody rigidbody;

    public Transform player;
    public float speed;
    public float turnspeed;

    private int Hits = 0;

    private AudioManager audioManager;

	void Start () {
        audioManager = AudioManager.instance;
        enemyParticles.Play();
        

    }

    /*
    if ball collides with enemy, do the following:
    -destroy the enemy
    -play a noise
    -play a particle system
    -add points??

    
         
         */


    void Update() {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed);

        Vector3 targetDir = player.position - transform.position;
        float step = turnspeed * Time.deltaTime;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir); 
    }

	void OnTriggerEnter () {
        {
            enemyParticles.Play();

            if (Hits < 2) {
                audioManager.PlaySound("Enemy");
                rigidbody.useGravity = true;
                Hits = Hits + 1;
            }

            if (Hits == 2) {
                Destroy(enemy);
            }   
        }
    }

}
