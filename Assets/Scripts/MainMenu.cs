using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

  void Start() {
    Time.timeScale = 0f;
  }

  public void PlayGame() {
    Debug.Log("Play Game");
    Time.timeScale = 1f;
    Debug.Log(SceneManager.GetActiveScene().buildIndex);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void QuitGame(){
    Debug.Log("Quit Game");
    Application.Quit();
  }
}
