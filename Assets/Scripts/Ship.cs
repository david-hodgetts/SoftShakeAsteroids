using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	
	
	public float rotationSpeed = 300;
	public float thrustForce = 20;


	
	// Update is called once per frame
	void Update () {
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		transform.Rotate(0, rotation, 0);
	}
	
	// called every fixed framerate frame (physics)
	void FixedUpdate(){
		if (Input.GetMouseButton(0)){
			Vector3 force = transform.forward * thrustForce;
			rigidbody.AddForce(force);
		}
	}
}
