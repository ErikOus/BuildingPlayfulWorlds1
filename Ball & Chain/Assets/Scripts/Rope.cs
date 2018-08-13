using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour {

	private LineRenderer lineRenderer;
	private float counter;
	private float dist;

	public Transform origin;
	public Transform part1;
	public Transform part2;
	public Transform part3;
	public Transform part4;
	public Transform part5;
	public Transform part6;
    public Transform part7;
    public Transform part8;
    public Transform part9;


	// Use this for initialization
	void Start () {
		lineRenderer = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		lineRenderer.SetPosition (0, origin.position);
		lineRenderer.SetPosition (1, part1.position);
		lineRenderer.SetPosition (2, part2.position);
		lineRenderer.SetPosition (3, part3.position);
		lineRenderer.SetPosition (4, part4.position);
		lineRenderer.SetPosition (5, part5.position);
		lineRenderer.SetPosition (6, part6.position);
        lineRenderer.SetPosition (7, part7.position);
        lineRenderer.SetPosition (8, part8.position);
        lineRenderer.SetPosition (9, part9.position);


    }
}
