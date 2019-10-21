using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
  public GameObject gameOverMenu;

  void Update() {
    if(Player.lives <= 0) {
      Time.timeScale = 0f;
      gameOverMenu.SetActive(true);
    }
  }

  public void Restart() {
    Player.lives = 5;
    gameOverMenu.SetActive(false);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    Time.timeScale = 1f;
  }

  public void LoadMenu() {
    SceneManager.LoadScene("MainMenu");
  }

  public void QuitGame() {
    Application.Quit();
  }
}
