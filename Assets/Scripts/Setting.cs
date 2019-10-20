using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour {
  private int gameLevel;
  private int[] gameStages = {3, 5, 9, 13, 17, 20, 23, 27, 30, 34, 40, 50, 70, 99};

  public static float cloudsSpeed;

  void Start() {
    cloudsSpeed = -3F;
    gameLevel = 0;
  }

  void Update() {
    if(shouldChangeStage(gameStages[gameLevel])) {
      changeCloudsSpeed(gameStages[gameLevel + 1]);
    }
    if(shouldChangeStage(gameStages[gameLevel])) {
      changeCloudsSpeed(gameStages[gameLevel+1]);
    }
    if(shouldChangeStage(gameStages[gameLevel])) {
      changeCloudsSpeed(gameStages[gameLevel + 1]);
    }
  }

  void changeCloudsSpeed(int stage) {
    gameLevel += 1;
    cloudsSpeed -= 0.5F;
  }

  bool shouldChangeStage(int points) {
    return (points == Player.lightningboltsCollected && gameStages[gameLevel] == points);
  }
}
