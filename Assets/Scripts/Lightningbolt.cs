using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightningbolt : MonoBehaviour {
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
      other.GetComponent<Player>().lightningboltsCollected = other.GetComponent<Player>().lightningboltsCollected + 1;
      Debug.Log("Lightning Bolts Collected: " + other.GetComponent<Player>().lightningboltsCollected);
      Destroy(gameObject);
    }
  }
}
