using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

  public GameObject mainMenu;

  void Start() {
    Time.timeScale = 0f;
  }

  public void PlayGame() {
    Time.timeScale = 1f;
    mainMenu.SetActive(false);
  }

  public void QuitGame(){
    Debug.Log("QuitGame");
    Application.Quit();
  }
}
