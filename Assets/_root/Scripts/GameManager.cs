using GlobalBasket;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

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

    [field: SerializeField] public static Saver saver;

    public static int[] scoreTier = new int[2];
    public static int starCount;
    public const int totalStars = 3;
    [field: SerializeField] public int starsRemaining { get; private set; }


    private void Awake()
    {
        input = new();
    }

    // Start is called before the first frame update
    void Start()
    {
        //saver = FindObjectOfType<Saver>();
        Application.targetFrameRate = 420;
        //saver = LevelScoreData as Saver;
        saver = Resources.Load<Saver>("UserData");
        //saver.LoadfromJson();
        //saver.LoadfromJson(saver);
        /*try
        {
            saver.LoadfromJson(saver);
        }
        catch (Exception e)
        {
            print(e);
            saver.SavetoJson(saver);
        }*/

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
        LevelReporting.LevelComplete += StarScoring;
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
        LevelReporting.LevelComplete -= StarScoring;
        UIController.OnRestartfromUI -= ResetTimer;
    }

    void GetLevelInfo()
    {
        currentArenaNo = LevelManager.currentArena;
        currentLevelNo = LevelManager.currentLevel;
        starsRemaining = totalStars - saver.arenas[currentArenaNo].levels[currentLevelNo].starCount;
    }

    void StarScoring()
    {
        //starCount = timer < scoreTier[0] + 1 ? 3 : timer < scoreTier[1] + 1 ? 2 : 1;
        void SaveStars()
        {
            saver.arenas[currentArenaNo].levels[currentLevelNo].starCount = starCount;
            saver.usrdata.starbalance += starCount;
            starsRemaining -= starCount;
        }

        if (timer < scoreTier[0] + 1)
        {
            starCount = 3;
            if (starsRemaining > 0)
                SaveStars();
        }
        else if (timer < scoreTier[1] + 1)
        {
            starCount = 2;
            if (starsRemaining > 1)
                SaveStars();
        }
        else
        {
            starCount = 1;
            if (starsRemaining > 2)
                SaveStars();
        }

        UnlockLevels();
        saver.SavetoJson(saver);
    }

    void UnlockLevels()
    {
        if (currentLevelNo < 16)
            saver.arenas[currentArenaNo].levels[currentLevelNo + 1].Unlocked = true;
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

        IEnumerator UpdateBallCount()
        {
            yield return new WaitForSeconds(0.1f);
            scoreboard[3].text = LevelReporting.ballCount.ToString();
        }
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

