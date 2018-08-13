using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController1 : MonoBehaviour {

    public Rigidbody rbBall;
    public Collider rbColl;
    public GameObject closedPosition;
    public GameObject chain;
    public LineRenderer chainRenderer;
    public ParticleSystem shootParticles;
    private bool shot = true;

    private AudioManager audioManager;

    public int shootSpeed;
    public float interpolation;

    void Start () {
        audioManager = AudioManager.instance;	
	}

	void Update () {

        /*when rmb is pressed, do the following:
        + set the ball to kinematic 
        + move te ball and rope to the close position

        when lmb is pressed, do the following:
        - shoot the ball forward, using a raycast to see how far
        - after shooting, turn off the ball's isKinematic
        - while extending, change the location of all the ropebits to a percentage of the raycasts length

        position.y = Mathf.Lerp(transform.position.y, Player.transform.position.y - camheight, interpolation);
       */
        Vector3 position = rbBall.transform.position;

        //retracting
        if (Input.GetMouseButtonDown(1))
        {
            if (shot == true) {
                rbBall.isKinematic = true;
                rbBall.transform.position = closedPosition.transform.position;
                rbBall.transform.rotation = closedPosition.transform.rotation;
                rbBall.transform.parent = closedPosition.transform;
                chainRenderer.startWidth = 0f;
                rbColl.isTrigger = true;
                audioManager.PlaySound("Retract");
                shot = false;
            }
        }

        //shooting
        if (Input.GetMouseButtonDown(0))
        {
            if (shot == false) {
                rbBall.transform.parent = chain.transform;
                rbBall.isKinematic = false;
                rbBall.AddForce(rbBall.transform.forward * shootSpeed);
                chainRenderer.startWidth = 0.4f;
                audioManager.PlaySound("Shoot");
                rbColl.isTrigger = false;
                shootParticles.Play();
                shot = true;
            }
        }
    }
}
