using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// TODO: Stage is base class?
public class Stage : MonoBehaviour {

	private string initialNegativeMessage = "Actualmente la deforestación acaba con los bosques del mundo";
	private string initialPositiveMessage = "";
	private float time;
	private float availableTime = 1f; // In minuts

	private Player player;

	public GameObject target;
	public GameObject collectible;
	public GameObject objective;
	public int quantityCollectibles = 1;
	public int quantityTargets = 1;


	void InitialNegativeMessage(){
		Debug.Log (initialNegativeMessage);
	}

	void FinalPositiveMessage(){
		Debug.Log (initialPositiveMessage);
		// Mensaje final sobre como ayudar a natura y el impacto positivo
	}

	void Timer() {
		time += Time.deltaTime;

		float minutes = time / 60; // Divide the guiTime by sixty to get the minutes.
		float seconds = time % 60; // Use the euclidean division for the seconds.
		float fraction = (time * 100) % 100;

		// update the label value
		Debug.Log(string.Format ("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction));
	}

	void OverTime() {
		if (availableTime <= time / 60) {
			Time.timeScale = 0;
			player.set_is_winner (false);
		}
	}

	void Winner(){
		if (player.get_is_winner() == true) {
			VictoryAction ();
			FinalPositiveMessage ();
			player.set_is_winner (false);
		}
	}

	void GameOver(){
		// Mostrar ventana de GameOver
	}

	void Pause() {
		
	}

	void RetryMenu() {
		
	}

	void GenerateCollectibles() {
		GameObject terrain = GameObject.Find ("Terrain");

		int terrainWidth = (int)terrain.GetComponent<Terrain> ().terrainData.size.x;
		int terrainLength = (int)terrain.GetComponent<Terrain> ().terrainData.size.z;
		int terrainPosX = (int)terrain.GetComponent<Terrain> ().transform.position.x;
		int terrainPosZ = (int)terrain.GetComponent<Terrain> ().transform.position.z;

		for (int i = 0; i < quantityCollectibles; i ++) {
			int posx = Random.Range(terrainPosX, terrainPosX + terrainWidth);
			int posz = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
			float posy = Terrain.activeTerrain.SampleHeight(new Vector3(posx, 0, posz));
			Instantiate (collectible, new Vector3(posx, posy, posz), Quaternion.identity);
		}

	}

	void GenerateTargets() {
		GameObject terrain = GameObject.Find ("Terrain");

		int terrainWidth = (int)terrain.GetComponent<Terrain> ().terrainData.size.x;
		int terrainLength = (int)terrain.GetComponent<Terrain> ().terrainData.size.z;
		int terrainPosX = (int)terrain.GetComponent<Terrain> ().transform.position.x;
		int terrainPosZ = (int)terrain.GetComponent<Terrain> ().transform.position.z;

		for (int i = 0; i < quantityTargets; i ++) {
			int posx = Random.Range(terrainPosX, terrainPosX + terrainWidth);
			int posz = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
			float posy = Terrain.activeTerrain.SampleHeight(new Vector3(posx, 0, posz));
			Instantiate (target, new Vector3(posx, posy, posz), Quaternion.identity);
		}
	}

	void GenerateObstacles() {

	}

	void VictoryAction () {
		// Mostrar el arbol y animar al personaje
		Instantiate(objective, Vector3.zero, Quaternion.identity);
	}
		
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player").GetComponent<Player>();
		InitialNegativeMessage ();
		GenerateCollectibles ();
		GenerateTargets ();
	}
	
	// Update is called once per frame
	void Update () {
		GenerateObstacles ();
		Timer ();
		OverTime ();
		Winner ();
	}
}
