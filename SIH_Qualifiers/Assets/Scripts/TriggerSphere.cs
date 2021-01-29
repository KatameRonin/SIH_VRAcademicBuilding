using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSphere : MonoBehaviour {

	public Transform nexSphere;
	public float timer = 0.0f;
	public bool move=false;

	private void OnTriggerEnter(Collider obj){
		
		if (obj.tag == "Player") {
		
			move = true;

			while (timer <= 2.5f) {
				timer += Time.deltaTime;
			}

			Camera.main.transform.parent.position = nexSphere.position;

		}
	}
		
}
