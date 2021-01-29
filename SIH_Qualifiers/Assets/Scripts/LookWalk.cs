using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookWalk : MonoBehaviour {

	public bool move;
	public Transform vrCam;
	CharacterController cc;
	public float speed=1.75f;
	public float togAngle=19.0f;

	// Use this for initialization
	void Start () {
	
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (vrCam.eulerAngles.x >= togAngle & vrCam.eulerAngles.x < 79.0f) {
		
			move = true;
		} else {
			move = false;
		}

		if (move) {

			Vector3 forward = vrCam.TransformDirection (Vector3.forward);
			cc.SimpleMove (forward * speed);
		}
	}
}
