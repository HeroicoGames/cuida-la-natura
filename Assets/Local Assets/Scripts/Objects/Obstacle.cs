using UnityEngine;
using System.Collections;

public abstract class Obstacle : MonoBehaviour {

	public abstract void hurtPorcentage();

	public Obstacle(string name) {

		this.name = name;

	}

	// TODO: Dejar hurtPorcentage o PlayerDamage
	void PlayerDamage(){

		// Contacto con player
	
	}

	void Show(){
		// Cuando y donde aparece
	}

	void Hide(){
	
		// Cuando y como desaparece
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		hurtPorcentage ();
	}
}
