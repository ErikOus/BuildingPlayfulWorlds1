using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcollision : MonoBehaviour {

    private AudioManager audioManager;

    public Rigidbody metalrb;
    public Rigidbody rb;
    public Rigidbody placeholder;
    public Joint magnetJoint;

    void Start() {
    audioManager = AudioManager.instance;
    }

    void OnCollisionEnter(Collision collision)
    {

        metalrb = collision.gameObject.GetComponent<Rigidbody>();

        audioManager.PlaySound("BallCollision");

        if (collision.gameObject.tag == "Metal")
        {
            if (rb.isKinematic == false)
            {
                magnetJoint.connectedBody = metalrb;
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            magnetJoint.connectedBody = placeholder;
        }
    }
}
