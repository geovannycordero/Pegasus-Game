using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

	/*** Para el control de la musica de fondo ***/
	private AudioSource music;

	void Start()
	{
		music = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update()
	{
		// interruptor para la musica
		if(Input.GetKeyDown(KeyCode.M))
		{
			music.mute = !music.mute;
		}
	}
}
