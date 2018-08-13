using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiothingy : MonoBehaviour {

	private AudioSource windSource;

	// Use this for initialization
	void Start () {
		windSource = (AudioSource)GetComponent (typeof(AudioSource));
		windSource.Play ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
