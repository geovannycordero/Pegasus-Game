using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
  public static bool gameIsPaused = false;

  public GameObject pauseMenu;

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
    Time.timeScale = 1f;
    gameIsPaused = false;
  }

  void Pause() {
    pauseMenu.SetActive(true);
    Time.timeScale = 0f;
    gameIsPaused = true;

  }

  public void LoadMenu() {
    Debug.Log("Load Menu");
    SceneManager.LoadScene("MainMenu");
  }

  public void QuitGame() {
    Debug.Log("Quit Game");
    Application.Quit();
  }
}
