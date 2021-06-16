using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public Text TextTimer;
    public GameObject PanPause;

    [Header("Game Over Panel")]
    public GameObject panGameOver;
    public Text TxtScore;
    public Text TxtBestScore;
    [Header("Settings")]
    public float GameTimerScale = 60f;

    // Components
    float gameTimer;
    // Update is called once per frame
    void Update()
    {
        TimerWork();
    }
    private void Awake()
    {
        gameTimer = GameTimerScale;
        GameController.Score = 0f;
        GameController.DriftEnter = false;
        GameController.GameIsOver = false;
    }
    void TimerWork()
    {
        if (!GameController.GameIsOver)
        {
            if (gameTimer > 0)
            {
                gameTimer -= Time.deltaTime;
                if (Convert.ToInt32(gameTimer) > 59f)
                {
                    TextTimer.text = "1:00";
                }
                else
                {
                    if (Convert.ToInt32(gameTimer) > 9f)
                    {
                        TextTimer.text = "0:" + Convert.ToInt32(gameTimer).ToString();
                    }
                    else
                    {
                        TextTimer.text = "0:0" + Convert.ToInt32(gameTimer).ToString();
                    }

                }
            }
            else
            {
                GameOver();
            }
        }

    }
    public void GameOver()
    {
        GameController.GameIsOver = true;
        Time.timeScale = 0;
        var gameBuffer = GetComponent<ScoreCounter>().GetScoreBuffer;
        if (gameBuffer > 0)
        {
            GameController.Score += gameBuffer;
        }
        if (PlayerPrefs.HasKey("BestScore"))
        {
            TxtBestScore.text = "Best score: " + PlayerPrefs.GetInt("BestScore").ToString();
            if (PlayerPrefs.GetInt("BestScore") < GameController.Score)
            {
                PlayerPrefs.SetInt("BestScore", Convert.ToInt32(GameController.Score));
            }
        }
        else
        {
            PlayerPrefs.SetInt("BestScore", Convert.ToInt32(GameController.Score));
        }

        TxtScore.text = Convert.ToInt32(GameController.Score).ToString();


        panGameOver.SetActive(true);
    }
    public void PressMenuBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }

    public void PressRestartBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void PressPauseBtn()
    {
        Time.timeScale = 0;
        PanPause.SetActive(true);

    }
    public void PressResumeBtn()
    {
        PanPause.SetActive(false);
        Time.timeScale = 1;
    }

}
