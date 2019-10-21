using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour {

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
  public bool stopSpawn=false;
  
  void Start() {
    int initialDistanceArrowLightning = 3;
    if (Random.Range(0, 2) == 0) {
      timeBetweenArrowSpawn = Random.Range(minPauseTime, maxPauseTime) + initialDistanceArrowLightning;
    } else {
      timeBetweenThunderSpawn = Random.Range(minPauseTime, maxPauseTime) + initialDistanceArrowLightning;
    }

	timeBetweenAnemonaSpawns = 6f;
  }

  void Update() {
    timeBetweenArrowSpawn -= Time.deltaTime;
    timeBetweenThunderSpawn -= Time.deltaTime;
    timeBetweenTwisterSpawn -= Time.deltaTime;
	timeBetweenAnemonaSpawns -= Time.deltaTime;

    if (timeBetweenThunderSpawn <= 0) {
      createThunderObject();	

    }
    if (timeBetweenArrowSpawn <= 0) {
      createArrowObject();
    }
    if (timeBetweenTwisterSpawn <= 0) {
      if(0 < Player.lightningboltsCollected) {
        createTwisterObject();
      }
    }

	if(timeBetweenAnemonaSpawns <= 0){
		
		int randomNumber = Random.Range(0, initialPositions.Length);
        Instantiate(anemona, initialPositions[randomNumber], Quaternion.identity);
		timeBetweenAnemonaSpawns = 6f;
	}
	
  } // Update


  void createArrowObject() {
    Instantiate(
    arrow,
    initialPositions[Random.Range(0, initialPositions.Length)],
    Quaternion.identity
    );
    timeBetweenArrowSpawn = Random.Range(minPauseTime, maxPauseTime);
  }

  void createThunderObject(){
    Instantiate(
    lightning,
    initialPositions[Random.Range(0, initialPositions.Length)],
    Quaternion.identity
    );
    timeBetweenThunderSpawn = Random.Range(minPauseTime, maxPauseTime);
  }

  void createTwisterObject() {
    Instantiate(
    tornado,
    initialPositions[Random.Range(0, initialPositions.Length)],
    Quaternion.identity
    );
    timeBetweenTwisterSpawn = Random.Range(minPauseTime, maxPauseTime);
  }
}

