using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{

  private float timeBetweenAnemonaSpawns;

  // Time to decrease when there is a level up
  //public Vector2[] initialPositions;
  public int maxPauseTimeArrow;
  public int minPauseTimeArrow;
  public int maxPauseTimeThunder;
  public int minPauseTimeThunder;
  public int initialDistanceArrowLightning;

  //prefabs
  public GameObject arrow, lightning, tornado, anemona;

  private int minPauseTime = 3, maxPauseTime = 5;
  private float timeBetweenArrowSpawn, timeBetweenThunderSpawn, timeBetweenTwisterSpawn;
  public Vector3[] initialPositions; // Time to decrease when there is a level up


  // para detener la generacion de enemigos durante el cambio de dificultad
  public static bool stopSpawn = false;

  void Start()
  {
    int initialDistanceArrowLightning = 3;
    if (Random.Range(0, 2) == 0)
    {
      timeBetweenArrowSpawn = Random.Range(minPauseTime, maxPauseTime) + initialDistanceArrowLightning;
    }
    else
    {
      timeBetweenThunderSpawn = Random.Range(minPauseTime, maxPauseTime) + initialDistanceArrowLightning;
    }
    timeBetweenAnemonaSpawns = 6f;
  }

  void Update()
  {
	if(!stopSpawn){
		timeBetweenArrowSpawn -= Time.deltaTime;
		timeBetweenThunderSpawn -= Time.deltaTime;

		if (timeBetweenThunderSpawn <= 0)
		{
		  createThunderObject();
		}
		if (timeBetweenArrowSpawn <= 0)
		{
		  createArrowObject();
		}
		//porque los tornados se van a generar en el nivel dos y a partir del nivel cuatro para asi ir aumentando
		//la dificultad gradualmente
		if ((Player.level == 2) || (Player.level > 3))
		{
		  timeBetweenTwisterSpawn -= Time.deltaTime;
		  if (timeBetweenTwisterSpawn <= 0)
		  {
			if (0 < Player.lightningboltsCollected)
			{
			  createTwisterObject();
			}
		  }
		}
		//porque las anemoi se van a comenzar a generar a partir del nivel 3
		if (Player.level > 2)
		{
		  timeBetweenAnemonaSpawns -= Time.deltaTime;
		  if (timeBetweenAnemonaSpawns <= 0)
		  {
			int randomNumber = Random.Range(0, initialPositions.Length);
			Instantiate(anemona, initialPositions[randomNumber], Quaternion.identity);
			timeBetweenAnemonaSpawns = 6f;
		  }
		}
	}

  } // Update

  void createArrowObject()
  {
    Instantiate(
    arrow,
    initialPositions[Random.Range(0, initialPositions.Length)],
    Quaternion.identity
    );
    timeBetweenArrowSpawn = Random.Range(minPauseTime, maxPauseTime);
  }

  void createThunderObject()
  {

    Instantiate(
    lightning,
    initialPositions[Random.Range(0, initialPositions.Length)],
    Quaternion.identity
    );
    timeBetweenThunderSpawn = Random.Range(minPauseTime, maxPauseTime);
  }

  void createTwisterObject()
  {
    Instantiate(
    tornado,
    initialPositions[Random.Range(0, initialPositions.Length)],
    Quaternion.identity
    );
    timeBetweenTwisterSpawn = Random.Range(minPauseTime, maxPauseTime);
  }
   
}
