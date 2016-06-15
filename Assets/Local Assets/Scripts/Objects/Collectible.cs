using UnityEngine;
using System.Collections;

public abstract class Collectible : MonoBehaviour {

	public string name;

	public Collectible(string new_name) {
		this.name = new_name;
	}

	public Collectible () {
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
