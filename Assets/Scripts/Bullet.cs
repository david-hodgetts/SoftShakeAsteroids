using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		Destroy(gameObject);
	}
}
