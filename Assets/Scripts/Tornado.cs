using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
  public float speed;
  public float minimumX;
  public float maxY;
  public float minY;

  private string direction;

  void Start()
  {
    float number = Random.Range(0.0f, 1.0f);
    if (number < 0.5f)
    {
      direction = "up";
    }
    else
    {
      direction = "down";
    }
  }

  void Update()
  {
    if (direction.Equals("up"))
    {
      transform.Translate(Vector2.left * speed * Time.deltaTime);
      transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    else
    {
      transform.Translate(Vector2.left * speed * Time.deltaTime);
      transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    //Checks if the object is on the top of the screen
    if(transform.position.y >= maxY)
    {
      direction = "down";
    }

    //Checks if the object is on the bottom of the screeen
    if( transform.position.y <= minY)
    {
      direction = "up";
    }

    if (transform.position.x <= minimumX)
    {
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
  }
}
