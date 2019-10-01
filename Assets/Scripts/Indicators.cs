using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Indicators : MonoBehaviour
{
  public GameObject livesText;
  public GameObject pointsText;

  void Update() {
    livesText.GetComponent<UnityEngine.UI.Text>().text = "Lives: " + Player.lives;
    pointsText.GetComponent<UnityEngine.UI.Text>().text = "Points: " + Player.lightningboltsCollected;
  }
}
