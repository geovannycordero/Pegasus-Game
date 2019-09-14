using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNube : MonoBehaviour
{
	//Vector que contendrá las 3 imagenes con nubes
	public Rigidbody2D[] nubes;
	//velocidad con las que se mueven las nubes
	public float velocidad = -0.5f;
	
	//vector que contiene la posición en donde respawnean la nube que se queda fuera de escuadre
	private Vector2 extremoDerecho = new Vector2(19f,0f);
	
	
  
    void Start()
    {
		//se rellena el vector con las nubes
        nubes = GetComponentsInChildren<Rigidbody2D>();
		
		//se les asigna velocidad a cada una
		for(int i =0; i<nubes.Length; i++)
			nubes[i].velocity = new Vector2(velocidad,0);
		//Debug.Log("[0]  "+nubes[0].position.ToString()+" [1] "+nubes[1].position.ToString()+" [2] "+nubes[2].position.ToString() );
    }

    // Update is called once per frame
    void Update()
    {
		//para fijarse si alguna de las nubes se sale del encuadre
		for(int i =0; i< nubes.Length; i++)
		{
		  //if(i == 1)
			//Debug.Log("Valor de position "+nubes[i].position.x );
			if(nubes[i].position.x <= -32f)
			{
			  //Debug.Log("Nubes "+i+".x menor que -20");
				nubes[i].MovePosition(extremoDerecho);
			  //Debug.Log("Nubes "+i+" ahora es "+ nubes[i].position.ToString() +"\n");
			}
		}		  
    }
}
