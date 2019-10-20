using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour {
	public Rigidbody2D[] clouds;
	private float velocity = -3F;
	//vector que contiene la posición en donde respawnean la nube que se queda fuera de escuadre
	private Vector2 extremoDerecho = new Vector2(19f,0f);

	void Start() {
		//se rellena el vector con las clouds
		clouds = GetComponentsInChildren<Rigidbody2D>();
		//se les asigna velocity a cada una
		for(int i =0; i<clouds.Length; i++)
		clouds[i].velocity = new Vector2(velocity,0);
	}

	// Update is called once per frame
	void Update() {
		//para fijarse si alguna de las clouds se sale del encuadre
		for(int i =0; i< clouds.Length; i++) {
			if(clouds[i].position.x <= -32f) {
				clouds[i].MovePosition(extremoDerecho);
			}
		}
	}
}
