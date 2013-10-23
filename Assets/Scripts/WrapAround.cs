using UnityEngine;
using System.Collections;

public class WrapAround : MonoBehaviour {

    void LateUpdate() {
        Vector3 viewPortPosition = Camera.main.WorldToViewportPoint(transform.position);
				
		if (viewPortPosition.x < -0.2f ){
			Vector3 wrappedAround = viewPortPosition;
			wrappedAround.x = 1.1f;
			transform.position = Camera.main.ViewportToWorldPoint(wrappedAround);
		}
		
		if (viewPortPosition.x > 1.2f ){
			Vector3 wrappedAround = viewPortPosition;
			wrappedAround.x = -0.1f;
			transform.position = Camera.main.ViewportToWorldPoint(wrappedAround);
		}
		
		if (viewPortPosition.y < -0.2f ){
			Vector3 wrappedAround = viewPortPosition;
			wrappedAround.y = 1.1f;
			transform.position = Camera.main.ViewportToWorldPoint(wrappedAround);
		}
		
		if (viewPortPosition.y > 1.2f ){
			Vector3 wrappedAround = viewPortPosition;
			wrappedAround.y = - 0.1f;
			transform.position = Camera.main.ViewportToWorldPoint(wrappedAround);
		}
	
    }
}
