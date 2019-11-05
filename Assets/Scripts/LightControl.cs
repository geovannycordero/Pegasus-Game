using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
	/*** Clase para controlar la lus una vez se avanse al nivel 5 ***/
	
	private Light directionalLight;
	public static bool recentLevelChange = false;
    // Start is called before the first frame update
    void Start()
    {
        directionalLight = GetComponent<Light> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(recentLevelChange)
		{
			if(Player.level == 3)
			{
				StartCoroutine("ReduceLight");
				recentLevelChange =false;
			}
			if(Player.level == 4)
			{
				StartCoroutine("ReduceLight");
				//directionalLight.intensity = 0.75f;
				recentLevelChange =false;
			}
			if(Player.level == 5)
			{
				StartCoroutine("ReduceLight");
				//directionalLight.intensity =  0.6f;
				recentLevelChange =false;
			}
			if(Player.level == 6)
			{
				StartCoroutine("ReduceLight");
				//directionalLight.intensity = 0.5f;
				recentLevelChange =false;
			}
			if(Player.level <3 )
			{
				recentLevelChange=false;
			}
		}
    }
	
	IEnumerator ReduceLight () 
	{
		for(int i  =0 ; i < 15; i++)
		{
			directionalLight.intensity-=0.01f;
			yield return new WaitForSeconds(0.5f);
		}
	}
}
