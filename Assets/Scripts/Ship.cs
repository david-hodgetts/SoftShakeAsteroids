using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	
	
	public float rotationSpeed = 300;
	public float thrustForce = 20;

	public Rigidbody bulletPrefab;
	public float bulletForce = 1000;
	
	// Update is called once per frame
	void Update () {
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		transform.Rotate(0, rotation, 0);
		
		if(Input.GetMouseButtonDown(1))
			Shoot();
		
	}
	
	// called every fixed framerate frame (physics)
	void FixedUpdate(){
		if (Input.GetMouseButton(0)){
			Vector3 force = transform.forward * thrustForce;
			rigidbody.AddForce(force);
		}
	}
	
	void Shoot(){
		Rigidbody bullet = Instantiate(bulletPrefab, 
									   transform.position + transform.forward, 
									   Quaternion.identity) as Rigidbody;
		
		bullet.rigidbody.AddForce(transform.forward * bulletForce);
		
	}
	
	
}
