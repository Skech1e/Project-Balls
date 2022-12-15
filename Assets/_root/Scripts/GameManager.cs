using GlobalBasket;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Scoring")]
    [SerializeField] protected int highScore, totalScore;
    [SerializeField] protected float timer, execTimer;
    public static int score;
    [SerializeField] int currentArenaNo, currentLevelNo;

    private PlayerInputs input;

    [SerializeField] List<TextMeshProUGUI> scoreboard = new(5);

    [SerializeField]
    bool touchedProperty;

    public delegate void OnScore();
    public static event OnScore OnScoreEvent;

    private Saver saver;
    [SerializeField] ScriptableObject LevelScoreData;



    private void Awake()
    {
        input = new();
    }

    // Start is called before the first frame update
    void Start()
    {
        saver = LevelScoreData as Saver;

        saver.LoadfromJson(saver);
    }

    // Update is called once per frame
    void Update()
    {
        CountUp();
    }

    private void OnEnable()
    {
        Scored.GoalScored += RecordAndUpdateScoreboard;
        Ball.BallEvent += CoroutineCaller;
        LevelReporting.LevelLoad += InitScoreboard;
        LevelReporting.LevelLoad += ResetTimer;
        UIController.OnRestartfromUI += ResetTimer;
    }

    private void OnDisable()
    {
        saver.SavetoJson(saver);

        input.Disable();
        input.Controls.Aim.started -= FirstTouch;
        input.Controls.Aim.performed -= FirstTouch;

        Scored.GoalScored -= RecordAndUpdateScoreboard;
        Ball.BallEvent -= CoroutineCaller;
        LevelReporting.LevelLoad -= InitScoreboard;
        LevelReporting.LevelLoad -= ResetTimer;
        UIController.OnRestartfromUI -= ResetTimer;
    }

    void GetLevelInfo()
    {
        currentArenaNo = LevelManager.currentArena;
        currentLevelNo = LevelManager.currentLevel;
    }

    void InitScoreboard()
    {
        GetLevelInfo();

        for (int i = 0; i < scoreboard.Capacity; i++)
            scoreboard[i] = GameObject.FindGameObjectWithTag("scb" + i).GetComponent<TextMeshProUGUI>();
        InitScoreboardData();

        input.Enable();
        input.Controls.Aim.started += FirstTouch;
        input.Controls.Aim.performed += FirstTouch;

    }

    void InitScoreboardData()
    {
        totalScore = 0;
        highScore = saver.arenas[currentArenaNo].levels[currentLevelNo].hiscore;
        scoreboard[0].text = highScore.ToString();
        scoreboard[1].text = totalScore.ToString();
        scoreboard[2].text = LevelReporting.bonus.ToString("F1");
        scoreboard[3].text = LevelReporting.ballCount.ToString();
    }

    void FirstTouch(InputAction.CallbackContext context)
    {
        var action = context.phase;
        if (action == InputActionPhase.Performed)
        {
            touchedProperty = true;
        }
    }

    void ResetTimer()
    {
        totalScore = 0;
        timer = 0;
        execTimer = 0;
        touchedProperty = false;
        scoreboard[4].text = string.Format("{0}:{1:00}",0 , 0);
        UpdateBallCount();
    }

    void CountUp()
    {
        if (Levels.IsLevelLoaded == true && touchedProperty == true)
        {
            timer += Time.deltaTime;
            DisplayTime(timer);
            BonusReduction();
        }
    }

    void DisplayTime(float timer)
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        scoreboard[4].text = string.Format("{0}:{1:00}", minutes, seconds);
        scoreboard[2].text = LevelReporting.bonus.ToString("F1"); //bonus display
    }

    /* SCORING */

    void RecordAndUpdateScoreboard()
    {
        ScorePerGoal();
        RecordScores();
        scoreboard[0].text = highScore.ToString();
        scoreboard[1].text = totalScore.ToString();
    }

    void BonusReduction()
    {
        if (LevelReporting.bonus > 1 && execTimer > 6.9f)
            LevelReporting.bonus -= 0.1f;

        execTimer += execTimer > 6.9f ? -execTimer : Time.deltaTime;
    }

    void CoroutineCaller()
    {
        StartCoroutine(UpdateBallCount());
    }
    IEnumerator UpdateBallCount()
    {
        yield return new WaitForSeconds(0.1f);
        scoreboard[3].text = LevelReporting.ballCount.ToString();
    }    

    void RecordScores()
    {
        int _arenano = LevelManager.currentArena;
        int _levelno = LevelManager.currentLevel;
        totalScore += score;
        highScore = totalScore > highScore ? totalScore : highScore;

        saver.arenas[_arenano].levels[_levelno].ballCount = LevelReporting.ballCount;
        saver.arenas[_arenano].levels[_levelno].hiscore = highScore;
        saver.arenas[_arenano].levels[_levelno].timeTaken = timer;
    }

    public int ScorePerGoal()
    {
        var _score = (float)LevelReporting.ScorePerBasket;
        score = Mathf.RoundToInt(_score * LevelReporting.bonus);

        return score;
    }

}

