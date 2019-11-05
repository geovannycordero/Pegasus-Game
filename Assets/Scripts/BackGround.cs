using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
	/*** Clase para controlar el movimiento de la imagen de fondo ***/
	
	private Rigidbody2D backGroundImage;
    // Start is called before the first frame update
    void Start()
    {
        backGroundImage = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		//basicamente si se detuvo el spawn de objetos y el nivel es menor que 6 mueve el fondo
		if(RandomObjectSpawner.stopSpawn && Player.level <= 6 )
		{
			Debug.Log("Entra a backGround");
			StartCoroutine("MoveBackGround");
			Debug.Log("Sale de backGround");
		}
        
    }
	
	
	//Corutina para mover el fondo a velocidad -4 durante 3 segundos. Luego habilita la generacion de objetos
	IEnumerator MoveBackGround () 
	{
		backGroundImage.velocity = new Vector2(-4f,0);
        yield return new WaitForSeconds(3f);
		backGroundImage.velocity = new Vector2(0,0);
		RandomObjectSpawner.stopSpawn=false;
	}
}
