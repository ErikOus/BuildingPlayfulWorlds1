using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController2 : MonoBehaviour {

			public Rigidbody ball;
			public GameObject prefab;
			public Transform shootPoint;
			public Transform previewCube;
			// Use this for initialization
			void Start () {

			}

			// Update is called once per frame
			void Update () {

				if (Input.GetMouseButtonDown(0))
				{
					previewCube.gameObject.SetActive(true);
				}

				if (Input.GetMouseButton(0))
				{
					RaycastHit hit;
					if (Physics.Raycast(shootPoint.position, shootPoint.forward, out hit))
					{
						previewCube.transform.position = hit.point;
					}

				}

				if (Input.GetMouseButtonDown(0))
				{
					previewCube.gameObject.SetActive(false);
					RaycastHit hit;
					if(Physics.Raycast(shootPoint.position, shootPoint.forward,out hit))
					{
						Instantiate(prefab, previewCube.transform.position, previewCube.transform.rotation);
					}
				}
			
			if (Input.GetMouseButtonDown(0))
			{
				RaycastHit hit;
				if(Physics.Raycast(shootPoint.position, shootPoint.forward,out hit))
				{
				ball.velocity = transform.forward * 10; 
				}
		}
	}
}
		


