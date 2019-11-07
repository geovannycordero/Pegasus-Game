using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 pegasusTargetPosition;
	
	public SpriteRenderer sprite;

    public float xValue;
    public float yStartPosition;

    private float speed = 3F;
    private float maximumY = 3.5F;
    private float minimumY = -3.5F;

    public static int lives;
	public static int lastLiveCount;
    public static int level;
    public static int lightningboltsCollected;
    public static int lightningCurrentLevel = 5;
    public static int lightningLastLevel = 0;
    public static int anemoiFights;
    public static float normalizedScore;
	
	//Prefab
	public GameObject attack;

    void Start() {
        lives = 5;
		lastLiveCount=5;
        level = 1;
        lightningboltsCollected = 0;
    }

    public static void restartPlayer()
    {
        lives = 5;
		lastLiveCount=5;
        level = 1;
        lightningLastLevel = 0;
        lightningboltsCollected = 0;
        lightningCurrentLevel = 5;
        anemoiFights = 0;
    }

    public int numLightningNextLevel()
    {
        return lightningCurrentLevel + lightningLastLevel;
    }

    public static float getNormalizedScore()
    {
        
        return (float)(lightningboltsCollected - (lightningLastLevel)) / (lightningCurrentLevel- lightningLastLevel);
    }

	
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0 && transform.position.y < maximumY)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") < 0 && transform.position.y > minimumY)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        //Para pasar de nivel el jugador debe haber recolectado una cierta cantidad de rayos, sin embargo,
        //para el puntaje tambien cuenta el numero de anemoi peleados
        if (lightningboltsCollected >= lightningCurrentLevel)
        {
            newLevel();
        }
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) )
        {
			Vector3 attackPosition = transform.position;
			attackPosition.x+= 1.3f;
            Instantiate(attack,attackPosition,Quaternion.identity);
        }
		//Si tiene menos vidas que en el anterior frame significa que sufrió daño
		if(lastLiveCount>lives)
		{
			lastLiveCount =lives;
			StartCoroutine("DamageEffect");
		}
    }

    public void newLevel()
    {
        level++;
		RandomObjectSpawner.stopSpawn = true;
		LightControl.recentLevelChange =true;
		
        if (lightningLastLevel == 0)
        {
            lightningLastLevel = 3;
        }
        int last = lightningLastLevel;
        lightningLastLevel = lightningCurrentLevel;
        lightningCurrentLevel = lightningCurrentLevel + last;
    }
	
	IEnumerator DamageEffect () 
	{
		Debug.Log("Daño");
		for(int i  =0 ; i < 3; i++)
		{
			GetComponent<SpriteRenderer>().color = Color.red;
			yield return new WaitForSeconds(0.05f);
			GetComponent<SpriteRenderer>().color = Color.white;
			yield return new WaitForSeconds(0.05f);
		}
	}

}
