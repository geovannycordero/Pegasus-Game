using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Indicators : MonoBehaviour
{
    public GameObject indicators, pointsText;
    public GameObject liveOneImage, liveTwoImage, liveThreeImage,
          liveFourImage, liveFiveImage;
    [SerializeField] private LevelScoreBar levelScoreBar;

  void Start() {
    if(SceneManager.GetActiveScene().buildIndex != 0) {
      indicators.SetActive(true);
      liveOneImage.SetActive(true);
      liveTwoImage.SetActive(true);
      liveThreeImage.SetActive(true);
      liveFourImage.SetActive(true);
      liveFiveImage.SetActive(true);
            
      levelScoreBar.setSize(0);
      
    }
  }
  void Update() {
    pointsText.GetComponent<UnityEngine.UI.Text>().text = "Points:    " + Player.lightningboltsCollected;
        
    levelScoreBar.setSize(Player.getNormalizedScore());
    if (Player.lives == 4) {
      liveFiveImage.SetActive(false);
    }
    if (Player.lives == 3) {
      liveFourImage.SetActive(false);
    }
    if (Player.lives == 2) {
      liveThreeImage.SetActive(false);
    }
    if (Player.lives == 1) {
      liveTwoImage.SetActive(false);
    }
        
  }
}
