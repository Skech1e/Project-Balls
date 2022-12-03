using GlobalBasket;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Scoring")]
    [SerializeField] protected int highScore, totalScore;
    [SerializeField] protected float timer, execTimer;
    public static int score;

    private readonly ScoreData scrdata = new();
    private Saver saver;
    private PlayerInputs input;

    [SerializeField] List<TextMeshProUGUI> scoreboard = new(5);

    [SerializeField]
    bool touchedProperty;

    public delegate void OnScore();
    public static event OnScore OnScoreEvent;

    [SerializeField] ScriptableObject LevelSCO;

    private void Awake()
    {
        saver = GetComponent<Saver>();
        input = new();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CountUp();
        BonusReduction();
    }

    private void OnEnable()
    {
        scrdata.HiScore = saver.LoadScores().HiScore;
        highScore = scrdata.HiScore;

        Scored.GoalScored += RecordAndUpdateScoreboard;
        SceneManager.sceneLoaded += InitScoreboard;
        Levels.OnLevelLoad += InitScoreboardData;
        UIController.OnUIEvent += ResetTimer;
        LevelManager.OnLevelChangeEvent += ResetTimer;
    }

    private void OnDisable()
    {
        saver.SavetoJson(scrdata);

        input.Disable();
        input.Controls.Aim.started -= FirstTouch;
        input.Controls.Aim.performed -= FirstTouch;
        Scored.GoalScored -= RecordAndUpdateScoreboard;
        SceneManager.sceneLoaded -= InitScoreboard;
        Levels.OnLevelLoad -= InitScoreboardData;
        UIController.OnUIEvent -= ResetTimer;
        LevelManager.OnLevelChangeEvent -= ResetTimer;
    }

    void InitScoreboard(Scene scene, LoadSceneMode mode)
    {
        for (int i = 0; i < scoreboard.Capacity; i++)
            scoreboard[i] = GameObject.FindGameObjectWithTag("scb" + i).GetComponent<TextMeshProUGUI>();
        InitScoreboardData();

        input.Enable();
        input.Controls.Aim.started += FirstTouch;
        input.Controls.Aim.performed += FirstTouch;
    }

    void InitScoreboardData()
    {
        scoreboard[0].text = scrdata.HiScore.ToString();
        scoreboard[1].text = totalScore.ToString();
        scoreboard[2].text = LevelReporting.bonus.ToString();
        scoreboard[3].text = LevelReporting.ballCount.ToString();
    }

    void FirstTouch(InputAction.CallbackContext context)
    {
        var action = context.phase;
        if (action == InputActionPhase.Performed)
        {
            print("ok");
            touchedProperty = true;

        }
    }

    void ResetTimer()
    {
        totalScore = 0;
        timer = 0;
        touchedProperty = false;
    }

    void CountUp()
    {
        if (Levels.IsLevelLoaded == true && touchedProperty == true)
        {
            timer += Time.deltaTime;
            DisplayTime(timer);
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
        scoreboard[3].text = LevelReporting.ballCount.ToString();

    }

    void BonusReduction()
    {
        if (LevelReporting.bonus > 1 && execTimer > 6.9f)
            LevelReporting.bonus -= 0.1f;

        execTimer += execTimer > 6.9f ? -execTimer : Time.deltaTime;
    }

    void RecordScores()
    {
        totalScore += score;
        highScore = totalScore > highScore ? totalScore : highScore;

        scrdata.HiScore = highScore;
        scrdata.Name = "test";

        
    }

    public int ScorePerGoal()
    {
        var _score = (float)LevelReporting.ScorePerBasket;
        score = Mathf.RoundToInt(_score * LevelReporting.bonus);

        return score;
    }

}

