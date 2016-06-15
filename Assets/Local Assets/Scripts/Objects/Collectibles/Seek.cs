using UnityEngine;
using System.Collections;

public class Seek: Collectible  {

	void OnTriggerEnter(Collider otherCollider) {
		Destroy (gameObject);
	}

}
