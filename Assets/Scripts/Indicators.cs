using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Indicators : MonoBehaviour
{
  public GameObject indicators;
  public GameObject pointsText;
  public GameObject liveOneImage;
  public GameObject liveTwoImage;
  public GameObject liveThreeImage;
  public GameObject liveFourImage;
  public GameObject liveFiveImage;

  void Start() {
    if(SceneManager.GetActiveScene().buildIndex != 0) {
      indicators.SetActive(true);
      liveOneImage.SetActive(true);
      liveTwoImage.SetActive(true);
      liveThreeImage.SetActive(true);
      liveFourImage.SetActive(true);
      liveFiveImage.SetActive(true);
    }
  }
  void Update() {
    pointsText.GetComponent<UnityEngine.UI.Text>().text = "Points:    " + Player.lightningboltsCollected;
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
