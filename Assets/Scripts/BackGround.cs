using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
	
	private Rigidbody2D backGroundImage;
    // Start is called before the first frame update
    void Start()
    {
        backGroundImage = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		
		if(RandomObjectSpawner.stopSpawn && Player.level <= 5 )
		{
			Debug.Log("Entra a backGround");
			StartCoroutine("MoveBackGround");
			Debug.Log("Sale de backGround");
		}
        
    }
	
	IEnumerator MoveBackGround () 
	{
		backGroundImage.velocity = new Vector2(-4f,0);
        yield return new WaitForSeconds(3f);
		backGroundImage.velocity = new Vector2(0,0);
		RandomObjectSpawner.stopSpawn=false;
	}
}
