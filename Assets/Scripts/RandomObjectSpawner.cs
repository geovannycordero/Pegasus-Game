using System.Collections.Generic;
using UnityEngine;


public class RandomObjectSpawner : MonoBehaviour {
  public GameObject arrow;
  public GameObject lightning;
  public GameObject twister;
  public GameObject anemona;

  float timeBetweenArrowSpawn;
  float timeBetweenThunderSpawn;
  float timeBetweenTwisterSpawn;

  // Time to decrease when there is a level up
  public Vector2[] initialPositions;
  int maxPauseTimeArrow = 3;
  int minPauseTimeArrow = 6;
  int maxPauseTimeThunder = 3;
  int minPauseTimeThunder = 6;
  int initialDistanceArrowLightning = 3;
  int minPauseTimeTwister = 0;
  int maxPauseTimeTwister = 5;

  void Start() {
    if (Random.Range(0, 2) == 0) {
      timeBetweenArrowSpawn = Random.Range(minPauseTimeArrow, maxPauseTimeArrow) + initialDistanceArrowLightning;
    } else {
      timeBetweenThunderSpawn = Random.Range(minPauseTimeArrow, maxPauseTimeArrow) + initialDistanceArrowLightning;
    }
    timeBetweenTwisterSpawn = Random.Range(minPauseTimeTwister, maxPauseTimeTwister) + initialDistanceArrowLightning - 1f;
  }

  void Update() {
    timeBetweenArrowSpawn -= Time.deltaTime;
    timeBetweenThunderSpawn -= Time.deltaTime;
    timeBetweenTwisterSpawn -= Time.deltaTime;

    if (timeBetweenThunderSpawn <= 0) {
      createThunderObject();
    }
    if (timeBetweenArrowSpawn <= 0) {
      if(0 < Player.lightningboltsCollected) {
        createArrowObject();
      }
    }
    if (timeBetweenTwisterSpawn <= 0) {
      if(4 < Player.lightningboltsCollected) {
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
    timeBetweenArrowSpawn = Random.Range(minPauseTimeArrow, maxPauseTimeArrow);
  }

  void createThunderObject(){
    Instantiate(
      lightning,
      initialPositions[Random.Range(0, initialPositions.Length)],
      Quaternion.identity
    );
    timeBetweenThunderSpawn = Random.Range(minPauseTimeThunder, maxPauseTimeThunder);
  }

  void createTwisterObject() {
    Instantiate(
      twister,
      initialPositions[Random.Range(0, initialPositions.Length)],
      Quaternion.identity
    );
    timeBetweenTwisterSpawn = Random.Range(minPauseTimeTwister, maxPauseTimeTwister);
  }
}
