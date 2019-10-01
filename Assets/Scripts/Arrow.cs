using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {
  public float speed;
  public float minimumX;

  void Update() {
    transform.Translate(Vector2.left * speed * Time.deltaTime);
    if (transform.position.x <= minimumX) {
      Destroy(gameObject);
    }
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
    else {
      Debug.Log(other.tag);
    }
  }
}
