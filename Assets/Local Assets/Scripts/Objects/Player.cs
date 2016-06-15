using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// private Inventory myInventory = new Inventory();
	Inventory myInventory;

	void PickUpCollectible(Collectible collectible){
		myInventory.AddCollectible (collectible);
	}

	void FinishPuzzleReaction(){
		// Contacto con la resolución del puzzle o parte de este
	}

	void ObstacleReaction(){
	
		// Animación cuando lo toca un obstaculo
	}

	// Use this for initialization
	void Start () {
		myInventory = gameObject.AddComponent<Inventory> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("q"))
			myInventory.CountCollectible ();
	}

	void OnTriggerEnter(Collider otherCollider) {
		PickUpCollectible (otherCollider.gameObject.GetComponent<Collectible>());
	}
}
