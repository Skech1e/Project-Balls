using GlobalBasket;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using static LevelUIManager;

public class GameManager : MonoBehaviour
{
    [Header("Scoring")]
    [SerializeField] protected int highScore;
    [SerializeField] public static float timer, execTimer;
    public static int score, totalScore;
    [SerializeField] int currentArenaNo, currentLevelNo;

    private PlayerInputs input;

    [SerializeField] List<TextMeshProUGUI> scoreboard = new(5);

    [SerializeField]
    bool touchedProperty;

    private Saver saver, loader;
    private Scores scoredata;
    public static ScriptableObject LevelScoreData;

    public static int[] scoreTier = new int[2];
    public static int starCount;


    private void Awake()
    {
        input = new();
    }

    // Start is called before the first frame update
    void Start()
    {
        saver = FindObjectOfType<Saver>();
        Application.targetFrameRate = 420;
        LevelScoreData = Resources.Load<ScriptableObject>("UserData");
        saver = LevelScoreData as Saver;
        //saver.LoadfromJson();
        saver.LoadfromJson(saver);
        
        //int i = 1; int j = 1;
        //foreach (Arena arena in arenas)
        //{
        //    arena.name = "Arena " + i;
        //    i = i < 10 ? (i + 1) : 1;
        //    foreach (Level level in arena.levels)
        //    {
        //        level.name = "Level " + j;
        //        j = j < 16 ? (j + 1) : 1;
        //    }
        //}
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
        LevelReporting.LevelComplete += UnlockLevels;
        UIController.OnRestartfromUI += ResetTimer;
    }

    private void OnDisable()
    {
        saver.SavetoJson(saver);
        //saver.SavetoJson(saver.scores);
        //saver.SavetoJson(saver.usrdata);

        input.Disable();
        input.Controls.Aim.started -= FirstTouch;
        input.Controls.Aim.performed -= FirstTouch;

        Scored.GoalScored -= RecordAndUpdateScoreboard;
        Ball.BallEvent -= CoroutineCaller;
        LevelReporting.LevelLoad -= InitScoreboard;
        LevelReporting.LevelLoad -= ResetTimer;
        LevelReporting.LevelComplete -= UnlockLevels;
        UIController.OnRestartfromUI -= ResetTimer;
    }

    void GetLevelInfo()
    {
        currentArenaNo = LevelManager.currentArena;
        currentLevelNo = LevelManager.currentLevel;
    }

    void UnlockLevels()
    {
        starCount = timer < scoreTier[0] + 1 ? 3 : timer < scoreTier[1] + 1 ? 2 : 1;
        saver.arenas[currentArenaNo].levels[currentLevelNo].starCount = starCount;

        if (currentLevelNo < 16)
            saver.arenas[currentArenaNo].levels[currentLevelNo + 1].Unlocked = true;
        saver.SavetoJson(saver);
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
        scoreboard[4].text = string.Format("{0}:{1:00}", 0, 0);
        CoroutineCaller();
    }

    void CountUp()
    {
        if (Levels.IsLevelLoaded == true && touchedProperty == true)
        {
            if (Ball.ballAtDefaultPos == true)
            {
                timer += Time.deltaTime;
            }
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
        totalScore += score;
        highScore = totalScore > highScore ? totalScore : highScore;

        saver.arenas[currentArenaNo].levels[currentLevelNo].ballCount = LevelReporting.ballCount;
        saver.arenas[currentArenaNo].levels[currentLevelNo].hiscore = highScore;
        saver.arenas[currentArenaNo].levels[currentLevelNo].timeTaken = timer;
        saver.arenas[currentArenaNo].levels[currentLevelNo].coins_earned += score;
        saver.usrdata.balance += score;
    }

    public int ScorePerGoal()
    {
        var _score = (float)LevelReporting.ScorePerBasket;
        score = Mathf.RoundToInt(_score * LevelReporting.bonus);

        return score;
    }

}

