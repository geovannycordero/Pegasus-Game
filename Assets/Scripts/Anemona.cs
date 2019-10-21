using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anemona : MonoBehaviour {
	public float speed;
<<<<<<< HEAD
	public float minimumX;
	public float maximumY;
	public float minimumY;
	
	public GameObject pegasus;
	
    // Start is called before the first frame update
    void Start()
    {
		
		pegasus = GameObject.FindWithTag("Player");
    }	
	
    // Update is called once per frame
    void Update()
    {
		float posPegasus = pegasus.GetComponent<Transform>().position.y;
        float dy = posPegasus - transform.position.y;
		
		// if facing up
		if(dy > 0){
			
			transform.Translate(Vector2.left * speed * Time.deltaTime);
			transform.Translate(Vector2.up * speed * Time.deltaTime);
		}
		// if facing down
		if(dy < 0){
			
			transform.Translate(Vector2.left * speed * Time.deltaTime);
			transform.Translate(Vector2.down * speed * Time.deltaTime);
		}
		
		if(transform.position.x <= minimumX){
			
			Destroy(gameObject);
		}
    }// Update

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player")) {
		  Player.lives = Player.lives - 1;
		  
		  if(Player.lives <= 0) {
			Application.Quit();
		  }
		  Destroy(gameObject);
=======

	void Update() {
		transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player")) {
			Player.lives = Player.lives - 1;
			Destroy(gameObject);
>>>>>>> d2537fdbfa4f109509becc28b326225214201c92
		}
	}
}
