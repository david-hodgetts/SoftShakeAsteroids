using UnityEngine;
using System.Collections;


[RequireComponent (typeof (Rigidbody))]
public class Asteroid : MonoBehaviour {

	public float startForce = 100;
	
	int splitCount = 0;
	const int maxSplit = 4;

	void Start () {
		Vector2 randomDirection = Random.insideUnitCircle.normalized * startForce;
		Vector3 direction = new Vector3(randomDirection.x, 0, randomDirection.y);
	
		rigidbody.AddForce(direction);
	}
	
	
	void Update(){
		if(Input.GetKeyDown(KeyCode.Space))
			Split ();
	}
	
	void Split(){
		if (splitCount > maxSplit)
			return;
		
		for(int i = 0; i < 2; i++){
			Asteroid newInstance = Instantiate(this, 
										   	   transform.position, 
										   	   Quaternion.identity) as Asteroid;
		
			newInstance.SetSplitCount(splitCount + 1);
			
			newInstance.transform.localScale *= 0.75f;
				
		}
		

		
		Destroy (gameObject);
	}
	
	void SetSplitCount(int count){
		splitCount = count;
	}
}
