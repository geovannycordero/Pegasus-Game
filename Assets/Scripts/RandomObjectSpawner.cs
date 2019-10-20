using System.Collections.Generic;
using UnityEngine;


public class RandomObjectSpawner : MonoBehaviour {
  public GameObject arrow;
  public GameObject lightning;
  public GameObject tornado;
  public GameObject anemona;

  int minPauseTime = 3;
  int maxPauseTime = 5;
  int initialDistanceArrowLightning = 3;
  float timeBetweenArrowSpawn;
  float timeBetweenThunderSpawn;
  float timeBetweenTwisterSpawn;
  public Vector2[] initialPositions; // Time to decrease when there is a level up

  void Start() {
    if (Random.Range(0, 2) == 0) {
      timeBetweenArrowSpawn = Random.Range(minPauseTime, maxPauseTime) + initialDistanceArrowLightning;
    } else {
      timeBetweenThunderSpawn = Random.Range(minPauseTime, maxPauseTime) + initialDistanceArrowLightning;
    }
    timeBetweenTwisterSpawn = Random.Range(minPauseTime, maxPauseTime) + 2;
  }

  void Update() {
    timeBetweenArrowSpawn -= Time.deltaTime;
    timeBetweenThunderSpawn -= Time.deltaTime;
    timeBetweenTwisterSpawn -= Time.deltaTime;

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
  }

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
