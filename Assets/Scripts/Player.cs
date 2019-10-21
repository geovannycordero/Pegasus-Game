using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public Vector2 pegasusTargetPosition;
  public float speed;
  public float maximumY;
  public float minimumY;
  public float xValue;
  public float yStartPosition;
public class Player : MonoBehaviour {
  private float speed = 3F;
  private float maximumY = 3.5F;
  private float minimumY = -3.5F;
>>>>>>> d2537fdbfa4f109509becc28b326225214201c92
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
