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
  public int lives;
  public int lightningboltsCollected;

  // Start is called before the first frame update
  void Start()
  {
    pegasusTargetPosition = new Vector2(xValue, yStartPosition);
  }

  // Update is called once per frame
  void Update()
  {
    if (lives > 0)
    {
      //transform.position = Vector2.MoveTowards(transform.position, pegasusTargetPosition, speed);

      if (Input.GetAxis("Vertical") > 0 && transform.position.y < maximumY)
      {
        transform.Translate(Vector2.up * speed * Time.deltaTime);//* Time.deltaTime);
        //pegasusTargetPosition = new Vector2(xValue, transform.position.y + Yincrement);
      }
      else if (Input.GetAxis("Vertical") < 0 && transform.position.y > minimumY)
      {
        transform.Translate(Vector2.down * speed * Time.deltaTime);// * Time.deltaTime);
        //pegasusTargetPosition = new Vector2(xValue, transform.position.y - Yincrement);
      }
    }
    else
    {
      Destroy(gameObject);
    }
  }
}
