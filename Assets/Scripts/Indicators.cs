using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Indicators : MonoBehaviour
{
    public GameObject indicators, pointsText, levelText, levelUpMessage;
    public GameObject liveOneImage, liveTwoImage, liveThreeImage,
          liveFourImage, liveFiveImage;
    [SerializeField] private LevelScoreBar levelScoreBar;
    public static int level=1;
    public float secondsLevelUp;

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            indicators.SetActive(true);
            liveOneImage.SetActive(true);
            liveTwoImage.SetActive(true);
            liveThreeImage.SetActive(true);
            liveFourImage.SetActive(true);
            liveFiveImage.SetActive(true);
            levelUpMessage.SetActive(false);

            levelScoreBar.setSize(0);
            levelText.GetComponent<UnityEngine.UI.Text>().text = "Level:    " + level;

        }
    }
    void Update()
    {
        //Para pasar de nivel el jugador debe haber recolectado una cierta cantidad de rayos, sin embargo,
        //para el puntaje tambien cuenta el numero de anemoi peleados
        int score = Player.lightningboltsCollected + Player.anemoiFights;
        pointsText.GetComponent<UnityEngine.UI.Text>().text = "Score:    " + score;
        if (level != Player.level)
        {
            level = Player.level;
            levelText.GetComponent<UnityEngine.UI.Text>().text = "Level:    " + Player.level;
            levelUpMessage.SetActive(true);
            StartCoroutine(LateCall());
        }
        float nomalized = Player.getNormalizedScore();
        levelScoreBar.setSize(nomalized);
        if (Player.lives == 4)
        {
            liveFiveImage.SetActive(false);
        }
        if (Player.lives == 3)
        {
            liveFourImage.SetActive(false);
        }
        if (Player.lives == 2)
        {
            liveThreeImage.SetActive(false);
        }
        if (Player.lives == 1)
        {
            liveTwoImage.SetActive(false);
        }
        if (Player.lives < 1)
        {
            liveOneImage.SetActive(false);
            levelUpMessage.SetActive(false);
        }

    }

    IEnumerator LateCall()
    {
        yield return new WaitForSeconds(secondsLevelUp);
        levelUpMessage.SetActive(false);

    }
}
