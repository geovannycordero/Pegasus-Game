using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
  float lastTime;
  public GameObject pauseMenu;
  public static bool gameIsPaused = false;

  void Update() {
    if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)) {
      if(gameIsPaused) {
        Resume();
      }
      else {
        Pause();
      }
    }
  }

  public void Resume() {
    pauseMenu.SetActive(false);
    gameIsPaused = false;
    Time.timeScale = 1f;
  }

  void Pause() {
    pauseMenu.SetActive(true);
    Time.timeScale = 0f;
    gameIsPaused = true;
  }

  public void LoadMenu() {
    SceneManager.LoadScene("MainMenu");
  }

  public void QuitGame() {
    Debug.Log("Quit Game");
    Application.Quit();
  }
}
