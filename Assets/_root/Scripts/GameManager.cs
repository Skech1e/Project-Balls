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

    private readonly ScoreData scrdata = new();
    private Saver saver;
    private PlayerInputs input;

    [SerializeField] List<TextMeshProUGUI> scoreboard = new(5);

    [SerializeField]
    bool touchedProperty;

    public delegate void OnScore();
    public static event OnScore OnScoreEvent;

    LevelSCO levelsco;
    [SerializeField] ScriptableObject LevelScoreData;


    private void Awake()
    {
        saver = GetComponent<Saver>();
        input = new();        
    }

    // Start is called before the first frame update
    void Start()
    {
        levelsco = LevelScoreData as LevelSCO;
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
            touchedProperty = true;
        }
    }

    void ResetTimer()
    {
        totalScore = 0;
        timer = 0;
        touchedProperty = false;
        LoadScores();
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

    void LoadScores()
    {
        levelsco = AssetDatabase.LoadAssetAtPath<LevelSCO>(Path.Combine(Application.persistentDataPath, "scores.asset"));
    }    

    void RecordScores()
    {
        int _arenano = LevelManager.currentArena;
        int _levelno = LevelManager.currentLevel;
        totalScore += score;
        highScore = totalScore > highScore ? totalScore : highScore;

        scrdata.HiScore = highScore;
        scrdata.Name = "test";

        levelsco.arenas[_arenano].levels[_levelno].ballCount = LevelReporting.ballCount;
        levelsco.arenas[_arenano].levels[_levelno].hiscore = highScore;

        AssetDatabase.CreateAsset(levelsco, Path.Combine(Application.persistentDataPath, "scores.asset"));
        AssetDatabase.SaveAssets();
    }

    public int ScorePerGoal()
    {
        var _score = (float)LevelReporting.ScorePerBasket;
        score = Mathf.RoundToInt(_score * LevelReporting.bonus);

        return score;
    }

}

