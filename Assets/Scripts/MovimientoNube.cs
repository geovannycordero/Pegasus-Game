using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNube : MonoBehaviour
{
	
	public Rigidbody2D[] nubes;
	public float velocidad = -5f;
	private Vector2 extremoDerecho = new Vector2(16f,0f);
    // Start is called before the first frame update
    void Start()
    {
        nubes = GetComponentsInChildren<Rigidbody2D>();
		
		for(int i =0; i<nubes.Length; i++)
			nubes[i].velocity = new Vector2(velocidad,0);
		Debug.Log("[0]  "+nubes[0].position.ToString()+" [1]"+nubes[1].position.ToString()+" [2]"+nubes[2].position.ToString() );
    }

    // Update is called once per frame
    void Update()
    {
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
