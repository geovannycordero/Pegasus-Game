using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public Vector2 pegasusTargetPosition;
  
  public float xValue;
  public float yStartPosition;
  
  private float speed = 3F;
  private float maximumY = 3.5F;
  private float minimumY = -3.5F;

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
