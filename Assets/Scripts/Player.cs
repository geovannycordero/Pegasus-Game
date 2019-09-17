using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float xSpeed = 3;
    public float yChangeSpeed = 1;
    //public Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
        //if (rb.position.y > stageDimensions.y) { 
        if (Input.GetKey(KeyCode.DownArrow) /* No se haya salido de la pantalla*/)
        {
            rb.velocity = new Vector2(rb.velocity.x, -2);
        } else if (Input.GetKey(KeyCode.UpArrow) /* No se haya salido de la pantalla*/)
        {
            rb.velocity = new Vector2(rb.velocity.x, 2);
        } else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
        //}

    }
}
