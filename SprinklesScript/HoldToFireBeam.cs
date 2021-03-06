﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldToFireBeam : MonoBehaviour {

	public GameObject beam;
	public GameObject cube;
	public GameObject cubeLight;
	public CharacterController beamController;
	public bool BeamLoadStarted=false;
	//	public LineRenderer trail;

	//	public GameObject TrailEndBall;
	//	Vector3 trailPos;

	void Start () {


		cubeLight.SetActive (false);

		//trail.enabled = false;
//		StartCoroutine (BeamAttack ());
//		StartCoroutine (BeamEffect ());



	
	}

	// Update is called once per frame
	void Update () {
		if (beamController) {
			beamController.Move (new Vector3 (0, 0, 0.1f));
			//			trail.SetPosition (0, beam.transform.position);
		}

		if (Input.GetKey (KeyCode.Mouse0)) {

			StartCoroutine (BeamAttack ());
			StartCoroutine (BeamEffect ());

		
		} else if (BeamLoadStarted == true)
			StopAllCoroutines ();
		


	}
	IEnumerator BeamAttack()
	{	
		BeamLoadStarted = true;
		yield return new WaitForSeconds (5.3f);
		BeamLoadStarted = false;
		GameObject go= Instantiate (beam, cube.transform) as GameObject;
		beamController = go.GetComponent<CharacterController> ();




	}
	IEnumerator BeamEffect()
	{
		cubeLight.SetActive (true);
		yield return new WaitForSeconds (6f);
		cubeLight.SetActive (false);

	}





}
