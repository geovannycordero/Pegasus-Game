using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anemona : MonoBehaviour
{

	// velocidades para cada uno de los ejes
    public float verticalSpeed;
	public float horizontalSpeed;

    public float minimumX;
    public float maximumY;
    public float minimumY;

    public GameObject pegasus,attack;

    // Start is called before the first frame update
    void Start()
    {

        pegasus = GameObject.FindWithTag("Player");
		attack = GameObject.FindWithTag("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        float posPegasus = pegasus.GetComponent<Transform>().position.y;
        float dy = posPegasus - transform.position.y;

        // if facing up
		// si la distancia es mayor a 0.1 entonces debe moverse
		if(dy > 0.1f || dy < -0.1)
		{
			if (dy > 0f)
			{

				transform.Translate(Vector2.left * horizontalSpeed * Time.deltaTime);
				transform.Translate(Vector2.up * verticalSpeed * Time.deltaTime);
			}
			// if facing down
			if (dy < 0f)
			{

				transform.Translate(Vector2.left * horizontalSpeed * Time.deltaTime);
				transform.Translate(Vector2.down * verticalSpeed * Time.deltaTime);
			}
		}else{
			//En caso contrario se posiciones en el mismo Y del pegaso
			//Debug.Log(transform.position);
			// se crea un vector con la posicion actual de la anemoi y ajustada al y del pegaso
			Vector3  align = transform.position;
			align.y = posPegasus;
			transform.TransformPoint(align);
			transform.Translate(Vector2.left * horizontalSpeed * Time.deltaTime);

		}
        
		/*if(dy < 0.1f && dy > -0.1)
		{
			Debug.Log(transform.position);
			Vector3  temp = transform.position;
			temp.y = posPegasus;
			transform.TransformPoint(temp);
		}*/

        if (transform.position.x <= minimumX)
        {
            Destroy(gameObject);
        }
    }// Update

    void OnTriggerEnter2D(Collider2D other)
    {
		Debug.Log("Contacto");
        if (other.CompareTag("Player"))
        {
            Player.lives = Player.lives - 1;
            Destroy(gameObject);
        }else{
			
			if(other.CompareTag("Attack"))
			{
				Debug.Log("Contacto");
				Player.anemoiFights++;
				Destroy(gameObject);
			}
		}
    }
}
