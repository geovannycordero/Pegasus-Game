using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    private Vector2 pegasusTargetPosition;
    public float Yincrement;
    public float speed;
    public float maximumY;
    public float minimumY;
    public float xValue;
    public float yStartPosition;
    public int lives;

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
            transform.position = Vector2.MoveTowards(transform.position, pegasusTargetPosition, speed);
            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maximumY)
            {
                pegasusTargetPosition = new Vector2(xValue, transform.position.y + Yincrement);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minimumY)
            {
                pegasusTargetPosition = new Vector2(xValue, transform.position.y - Yincrement);
            }
        }
        else
        {

            Destroy(gameObject);
        }
    }
}
