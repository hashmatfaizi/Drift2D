using System.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ScoreCounter : MonoBehaviour
{
    public Text TextScore;
    public GameObject Car;
    public GameObject GoScoreBuffer;
    public Text ScoreBuffer;

    [Header("Settings")]
    public float TimeToCancelScoring = 2.0f;
    public float minSpeedForStartAddScore = 30.0f;
    public float ScoreMultiplier = 3.0f;

    // Components
    float scoreBuffer = 0;
    float timerToCancelScore = 0;

    public float GetScoreBuffer { get { return scoreBuffer; } }

    Rigidbody2D _carRb;

    private void Awake()
    {
        _carRb = Car.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CountScore();
    }

    // Methods
    // Score counter
    void CountScore()
    {
        if (GameController.DriftEnter 
            && (Mathf.Abs(_carRb.velocity.x) + Mathf.Abs(_carRb.velocity.x)) > minSpeedForStartAddScore)
        {
            timerToCancelScore = TimeToCancelScoring;

            scoreBuffer += (Mathf.Abs(_carRb.velocity.x)
                + Mathf.Abs(_carRb.velocity.x)) * Time.deltaTime * ScoreMultiplier;
            GoScoreBuffer.SetActive(true);
            ScoreBuffer.text = "+ " + Convert.ToInt32(scoreBuffer).ToString();
        }
        else
        {
            timerToCancelScore -= Time.deltaTime;
        }
        // If the car got off the road
        if (!GameController.CarOnTheRoad)
        {
            scoreBuffer = 0;
        }
        if (timerToCancelScore < 0)
        {
            GameController.Score += scoreBuffer;
            TextScore.text = Convert.ToInt32(GameController.Score).ToString();
            scoreBuffer = 0;
            GoScoreBuffer.SetActive(false);
        }
    }
}
