using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {
  //public int damage;
  public float speed;
  public float xStartValue;
  public float yStartValue;
  public float minimumX;

  void Start() {

  }

  // Update is called once per frame
  void Update() {
    transform.Translate(Vector2.left * speed * Time.deltaTime);
    if (transform.position.x <= minimumX) {
      Destroy(gameObject);
    }
  }

  void OnTriggerEnter2D(Collider2D other) {
    if (other.CompareTag("Player")) {
      other.GetComponent<Player>().lives = other.GetComponent<Player>().lives - 1;
      Debug.Log(other.GetComponent<Player>().lives);
      Destroy(gameObject);
    }
  }
}
