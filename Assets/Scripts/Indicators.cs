using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Indicators : MonoBehaviour
{
  public GameObject indicators;
  public GameObject livesText;
  public GameObject pointsText;

  void Start() {
    if(SceneManager.GetActiveScene().buildIndex != 0) {
      indicators.SetActive(true);
    }
  }
  void Update() {
    livesText.GetComponent<UnityEngine.UI.Text>().text = "Lives: " + Player.lives;
    pointsText.GetComponent<UnityEngine.UI.Text>().text = "Points: " + Player.lightningboltsCollected;
  }
}
