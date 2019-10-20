using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  public float speed;
  public float maximumY;
  public float minimumY;
  public float xValue;
  public float yStartPosition;
  public static int lives;
  public static int lightningboltsCollected;

  void Start() {
    lives = 5;
    lightningboltsCollected = 0;
  }

  void Update() {
    if (Input.GetAxis("Vertical") > 0 && transform.position.y < maximumY) {
      transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    else if (Input.GetAxis("Vertical") < 0 && transform.position.y > minimumY) {
      transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
  }
}
