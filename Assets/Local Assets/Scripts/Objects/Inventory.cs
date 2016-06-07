﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	private List<Collectible> collectibles = new List<Collectible> ();

	public void AddCollectible(Collectible collectible) {
		collectibles.Add (collectible);
	}

	public void CountCollectible() {
		print (collectibles.Count);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
