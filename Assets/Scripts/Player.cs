using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  private Vector2 pegasusTargetPosition;
  public float Yincrement;
  public float speed;
  public float maximumY;
  public float minimumY;
  public float xValue;
  public float yStartPosition;
  public static int lives;
  public static int lightningboltsCollected;

  void Start() {
    pegasusTargetPosition = new Vector2(xValue, yStartPosition);
    lives = 3;
    lightningboltsCollected = 1;
  }

  void Update() {
    if (lives > 0) {
      if (Input.GetAxis("Vertical") > 0 && transform.position.y < maximumY) {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
      }
      else if (Input.GetAxis("Vertical") < 0 && transform.position.y > minimumY) {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
      }
    }
    else {
      Destroy(gameObject);
    }
  }
}
