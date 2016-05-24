using UnityEngine;
using System.Collections;

public abstract class Obstacle {

	public string name;

	public Obstacle(string name) {
	
		this.name = name;

	}

	public abstract void hurtPorcentage();

}
