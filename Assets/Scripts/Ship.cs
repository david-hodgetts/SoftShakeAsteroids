using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	
	public float rotationSpeed = 300;


	
	// Update is called once per frame
	void Update () {
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		transform.Rotate(0, rotation, 0);
	}
}
