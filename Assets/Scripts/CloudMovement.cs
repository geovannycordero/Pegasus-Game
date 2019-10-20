using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour {
	public Rigidbody2D[] clouds;
	//vector que contiene la posición en donde respawnean la nube que se queda fuera de escuadre
	private Vector2 extremoDerecho = new Vector2(19f,0f);

	void Start() {
		clouds = GetComponentsInChildren<Rigidbody2D>();
	}

	void Update() {
		setCloudsSpeed();
		//para fijarse si alguna de las clouds se sale del encuadre
		for(int i = 0; i < clouds.Length; i++) {
			if(clouds[i].position.x <= -32f) {
				clouds[i].MovePosition(extremoDerecho);
			}
		}
	}

	void setCloudsSpeed() {
		for(int i =0; i<clouds.Length; i++)
			clouds[i].velocity = new Vector2(Setting.cloudsSpeed,0);
	}
}
