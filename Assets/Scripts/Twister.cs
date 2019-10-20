using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twister : MonoBehaviour
{
  private float speed = 3.5F;
  private float minimumX = -10F;
  private float maxY = 3.5F, minY = -3.5F;
  private int direction = 0; // 1 up, 0 down

  void Start() {
    if (Random.Range(0.0f, 1.0f) < 0.5f) {
      direction = 1;
    }
  }

  void Update() {
    if (direction == 1) {
      transform.Translate(Vector2.left * speed * Time.deltaTime);
      transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    else {
      transform.Translate(Vector2.left * speed * Time.deltaTime);
      transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    if(transform.position.y >= maxY) {
      direction = 0;
    }
    if( transform.position.y <= minY) {
      direction = 1;
    }
    if (transform.position.x <= minimumX) {
      Destroy(gameObject);
    }
  }

  void OnTriggerEnter2D(Collider2D other) {
    if (other.CompareTag("Player")) {
      Player.lives = Player.lives - 1;
      Destroy(gameObject);
    }
  }
}
