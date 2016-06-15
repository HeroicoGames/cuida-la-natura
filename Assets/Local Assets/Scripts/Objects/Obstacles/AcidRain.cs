using UnityEngine;
using System.Collections;

public class AcidRain : Obstacle {

	private int other_attr;

	public AcidRain(string name, int other_attr) : base(name) {
		this.other_attr = other_attr;
		Debug.Log (this.other_attr);
	}
	
	public override void hurtPorcentage() {
		Debug.Log ("Te quito 25 de vida");
	}
}
