using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	public int requiredCollectibles = 1;

	void IsCompletionCollectibles() {
		int collectibles = GameObject.Find ("Player").GetComponent<Player>().myInventory.CountCollectible ();

		if (collectibles >= requiredCollectibles) {
			print ("Eres la verga");
		} else {
			print ("Vamos a calmarno");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherCollider) {
		IsCompletionCollectibles ();
	}
}
