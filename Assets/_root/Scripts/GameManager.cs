using GlobalBasket;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using System.IO;

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
    public Saver sav;
    public static int[] scoreTier = new int[2];
    public static int starsGot, starsCredited;
    public const int totalStars = 3;
    [field: SerializeField] public int starsRemaining { get; private set; }

    public int STARS;

    [Header("GPG")]
    public static bool isConnectedOnline;
    TextMeshProUGUI check;
    string scpath, datapath;

    private void Awake()
    {
        input = new();
        saver = Resources.Load<Saver>("UserData");
        sav = saver;
        saver.LoadfromJson();
        saver.LoadUser();
    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 420;
        isConnectedOnline = Application.internetReachability == NetworkReachability.NotReachable ? false : true;
        /*saver = Resources.Load<Saver>("UserData");
        sav = saver;
        saver.LoadfromJson();
        saver.LoadUser();
        if (isConnectedOnline)
        {
            PlayGamesPlatform.Activate();
            PlayGamesPlatform.Instance.Authenticate(PlayGames.playGames.ProcessAuthentication);
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        CountUp();
        STARS = starsGot;
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
        isConnectedOnline = Application.internetReachability == NetworkReachability.NotReachable ? false : true;
        saver.SaveAll();
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
        starsRemaining = totalStars - saver.scoredata.arenas[currentArenaNo].levels[currentLevelNo].starCount;
    }

    void StarScoring()
    {
        if (timer < scoreTier[0] + 1) // * * *
        {
            starsGot = 3;
            starsCredited = starsRemaining;
        }
        else if (timer < scoreTier[1] + 1) // * *
        {
            starsGot = 2;
            starsCredited = starsRemaining - starsGot + 1;  // credit 2 stars if 3 remaining or 1 when 2 remaining
        }
        else // *
        {
            starsGot = 1;
            if (starsRemaining > 2)
                starsCredited = starsGot;
        }

    }
    public void SaveStars()
    {

        saver.scoredata.arenas[currentArenaNo].levels[currentLevelNo].starCount += starsCredited;
        saver.usrdata.inventory.starbalance += starsCredited;

        UnlockLevels();
        saver.SavetoJson(saver.scoredata);
    }

    void UnlockLevels()
    {
        if (currentLevelNo < 15)
            saver.scoredata.arenas[currentArenaNo].levels[currentLevelNo + 1].Unlocked = true;
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
        score = 0;
        totalScore = 0;
        starsGot = 0;
        highScore = saver.scoredata.arenas[currentArenaNo].levels[currentLevelNo].hiscore;
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
    }

    public void SaveScores()
    {
        var level = saver.scoredata.arenas[currentArenaNo].levels[currentLevelNo];
        level.ballCount = LevelReporting.ballCount;
        level.hiscore = highScore;
        level.timeTaken = timer;
        level.coins_earned += score;
        saver.usrdata.inventory.balance += score;

        level.ballCount = level.hiscore = (int)(level.timeTaken = level.coins_earned = 0);
    }

    public void ScorePerGoal()
    {
        var _score = (float)LevelReporting.ScorePerBasket;
        score = Mathf.RoundToInt(_score * LevelReporting.bonus);

        // return score;
    }

}

