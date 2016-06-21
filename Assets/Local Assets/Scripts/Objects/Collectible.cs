using UnityEngine;
using System.Collections;

public abstract class Collectible : MonoBehaviour {

	public string title;

	public Collectible(string new_title) {
		this.title = new_title;
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
