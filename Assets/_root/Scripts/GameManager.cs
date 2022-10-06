using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Scoring")]
    [ReadOnlyProperty] public int highScore;
    [ReadOnlyProperty] public int totalScore;
    [SerializeField] int timer, score, bonus;
    bool gameModeSelected, timedGame;

    enum GameMode { training, casual, rapidFire }

    [SerializeField] GameMode gameMode = new GameMode();

    [SerializeField] TextMeshProUGUI scb_Timer;

    private void Awake()
    {
        timedGame = false;
        gameModeSelected = false;
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
        timer -= timedGame == true && timer > 0 ? (int)Time.deltaTime : 0;
        DisplayTime(timer);
    }

    void DisplayTime(int timer)
    {
        int minutes = timer / 60;
        int seconds = timer % 60;
        scb_Timer.text = string.Format("{0}:{1}", minutes, seconds);
    }
}
