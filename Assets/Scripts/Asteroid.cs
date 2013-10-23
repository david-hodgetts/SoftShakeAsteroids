using UnityEngine;
using System.Collections;


[RequireComponent (typeof (Rigidbody))]
public class Asteroid : MonoBehaviour {

	public float startForce = 100;


	void Start () {
		Vector2 randomDirection = Random.insideUnitCircle.normalized * startForce;
		Vector3 direction = new Vector3(randomDirection.x, 0, randomDirection.y);
	
		rigidbody.AddForce(direction);
	}
}
