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
    [SerializeField][Range(3,9)] int ball_count;

    enum GameMode { select_one, casual, rapidFire }

    [SerializeField] GameMode gameMode = new GameMode();

    [SerializeField] Scored scores;
    private ScoreData scrdata = new();
    private Saver saver;

    [SerializeField] List<TextMeshProUGUI> scoreboard = new(3);
    private void Awake()
    {
        timedGame = false;
        gameModeSelected = false;
        saver = GetComponent<Saver>();

        foreach (var entry in scoreboard)
            entry.text = 0.ToString();
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
        RecordScores();
        UpdateScoreBoard();
    }

    private void OnEnable()
    {
        scrdata.HiScore = saver.LoadfromJson().HiScore;
        highScore = scrdata.HiScore;
    }

    private void OnDisable()
    {
        saver.SavetoJson(scrdata);
    }

    void GameModeSelection()
    {
        if (gameModeSelected == false)
        {
            switch (gameMode)
            {
                case GameMode.select_one:
                    gameModeSelected = false;
                    break;
                case GameMode.casual:
                    gameModeSelected = true;
                    break;
                case GameMode.rapidFire:
                    gameModeSelected = true;
                    timedGame = true;
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
        scoreboard[2].text = string.Format("{0}:{1:00}", minutes, seconds);
    }


    void RecordScores()
    {
        totalScore = scores.totalScore;
        highScore = totalScore > highScore ? totalScore : highScore;

        scrdata.HiScore = highScore;
        scrdata.Name = "test";
    }

    void UpdateScoreBoard()
    {
        scoreboard[0].text = highScore.ToString();
        scoreboard[1].text = totalScore.ToString();
    }

    public int ScorePerGoal()
    {
        score = 69;
        bonus = 0;
        return score + bonus;
    }

    public void BallCounter()
    {

    }
}
