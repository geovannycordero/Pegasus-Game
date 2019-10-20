using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anemona : MonoBehaviour {
	public float speed;

	void Update() {
		transform.Translate(Vector2.left * speed * Time.deltaTime);
		float DY = Player.lives;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player")) {
			Player.lives = Player.lives - 1;
			Debug.Log("Lives: " + Player.lives);
			if(Player.lives <= 0) {
				Debug.Log("Should quit");
				Application.Quit();
			}
			Destroy(gameObject);
		}
	}
}
