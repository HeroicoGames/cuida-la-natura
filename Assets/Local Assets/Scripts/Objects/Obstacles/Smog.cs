using UnityEngine;
using System.Collections;

public class Smog : Obstacle {

	private int other_attr;

	public Smog(string name, int other_attr) : base(name) {
		this.other_attr = other_attr;
		Debug.Log (this.other_attr);
	}

	public override void hurtPorcentage() {
		Debug.Log ("Te quito 20 de vida");
	}
}
