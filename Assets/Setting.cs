using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public static float cloudsSpeed;
    private int[] gameStages = {3, 5, 10, 15};
    private int gameLevel;


    void Start() {
      cloudsSpeed = -3F;
      gameLevel = 0;
    }

    void Update() {
      if(shouldChangeStage(gameStages[0])) {
        changeCloudsSpeed(gameStages[1]);
      }
      if(shouldChangeStage(gameStages[1])) {
        changeCloudsSpeed(gameStages[2]);
      }
      if(shouldChangeStage(gameStages[2])) {
        changeCloudsSpeed(gameStages[3]);
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
