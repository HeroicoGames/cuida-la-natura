using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// private Inventory myInventory = new Inventory();
	public Inventory myInventory;
	private bool is_winner;

	void PickUpCollectible(Collectible collectible){
		myInventory.AddCollectible (collectible);
	}

	void FinishPuzzleReaction(){
		// Contacto con la resolución del puzzle o parte de este
	}

	void ObstacleReaction(){
	
		// Animación cuando lo toca un obstaculo
	}

	public void set_is_winner(bool val) {
		is_winner = val;
	}

	public bool get_is_winner() {
		return is_winner;
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
		if (otherCollider.transform.tag == "Collectible") {
			PickUpCollectible (otherCollider.gameObject.GetComponent<Collectible>());
		}
	}
}
