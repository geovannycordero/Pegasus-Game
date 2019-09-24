using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {
  public float speed;
  public float minimumX;

  void Start() {
  }

  void Update() {
    transform.Translate(Vector2.left * speed * Time.deltaTime);
    if (transform.position.x <= minimumX) {
      Destroy(gameObject);
    }
  }

  void OnTriggerEnter2D(Collider2D other) {
    if (other.CompareTag("Player")) {
      other.GetComponent<Player>().lives = other.GetComponent<Player>().lives - 1;
      Debug.Log("Lives: " + other.GetComponent<Player>().lives);
      if(other.GetComponent<Player>().lives <= 0) {
        Debug.Log("Should quit");
        Application.Quit();
      }
      Destroy(gameObject);
    }

    else
    {
      Debug.Log(other.tag);
    }
  }
}
