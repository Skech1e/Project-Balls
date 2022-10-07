using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Scoring")]
    [SerializeField] int highScore;
    [SerializeField] int totalScore;
    [SerializeField] float timer;
    [SerializeField] int score, bonus;
    [SerializeField] bool gameModeSelected, timedGame;

    enum GameMode { training, casual, rapidFire }

    [SerializeField] GameMode gameMode = new GameMode();

    [SerializeField] TextMeshProUGUI scb_Timer;
    [SerializeField] Scored scores;
    private ScoreData scrdata = new();
    private Saver saver;
    private void Awake()
    {
        timedGame = false;
        gameModeSelected = false;
        saver = GetComponent<Saver>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Countdown();
        GameModeSelection();
        RecordScores()
    }

    private void OnDisable()
    {
        saver.SavetoJson();
    }

    void GameModeSelection()
    {
        if (gameModeSelected == false)
        {
            switch (gameMode)
            {
                case GameMode.training:
                    gameModeSelected = true;
                    break;
                case GameMode.casual:
                    gameModeSelected = true;
                    break;
                case GameMode.rapidFire:
                    {
                        gameModeSelected = true;
                        timedGame = true;
                    }
                    break;
            }
        }
    }

    void Countdown()
    {
        timer -= timedGame == true && timer > 0 ? Time.deltaTime : 0;
        
        DisplayTime(timer);
    }

    void DisplayTime(float timer)
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        scb_Timer.text = string.Format("{0}:{1:00}", minutes, seconds);        
    }

    void RecordScores()
    {
        totalScore = scores.totalScore;
        highScore = totalScore > scores.highscore ? totalScore : scores.highscore;

        scrdata.HiScore = highScore;
        scrdata.Name = null;
    }
}
