using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	public int requiredCollectibles = 1;
	private Player player;

	void IsCompletionCollectibles() {
		int collectibles = player.myInventory.CountCollectible ();

		if (collectibles >= requiredCollectibles) {
			player.set_is_winner (true);
		} else {
			print ("Vamos a calmarno");
		}
	}

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherCollider) {
		IsCompletionCollectibles ();
	}
}
