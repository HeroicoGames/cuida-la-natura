using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WorldEvents : MonoBehaviour {

	private string initialNegativeMessage = "Actualmente la deforestación acaba con los bosques del mundo";
	private float time;
	public GameObject seek;

	void ShowSeek() {
		GameObject terrain = GameObject.Find ("Terrain");

		int terrainWidth = (int)terrain.GetComponent<Terrain> ().terrainData.size.x;
		int terrainLength = (int)terrain.GetComponent<Terrain> ().terrainData.size.z;
		int terrainPosX = (int)terrain.GetComponent<Terrain> ().transform.position.x;
		int terrainPosZ = (int)terrain.GetComponent<Terrain> ().transform.position.z;

		int posx = Random.Range(terrainPosX, terrainPosX + terrainWidth);
		int posz = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
		float posy = Terrain.activeTerrain.SampleHeight(new Vector3(posx, 0, posz));
		Instantiate (seek, new Vector3(posx, posy, posz), Quaternion.identity);
	}

	void ShowHole() {
		
	}

	void ShowTree () {
		
	}

	void InitialNegativeMessage(){
		// Al empezar el nivel, mostrar un mensaje "negativo" sobre el estado actual de la natura
		Debug.Log (initialNegativeMessage);
	}

	void FinalPositiveMessage(){

		// Mensaje final sobre como ayudar a natura y el impacto positivo
	}

	void UpdateInventory(){
		// Actualizar los elementos que tiene el jugador
	}

	void UpdateTimer(){
	
		// Actualizar el contador de tiempo
	}

	void Win(){
	
		// Mostrar ventana de Ganaste
	}

	void GameOver(){
	
		// Mostrar ventana de GameOver
	}

	void Timer() {
		time += Time.deltaTime;

		var minutes = time / 60; //Divide the guiTime by sixty to get the minutes.
		var seconds = time % 60;//Use the euclidean division for the seconds.
		var fraction = (time * 100) % 100;

		//update the label value
		Debug.Log(string.Format ("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction));
	}
		
	// Use this for initialization
	void Start () {
		InitialNegativeMessage ();
		ShowSeek ();
	}
	
	// Update is called once per frame
	void Update () {
		Timer ();
	}
}
