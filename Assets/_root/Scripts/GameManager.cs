using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Scoring")]
    [SerializeField] protected int highScore, totalScore;
    [SerializeField] protected float timer;
    [SerializeField][Range(3,9)] int ball_count;
    public static int score;


    private readonly ScoreData scrdata = new();
    private Saver saver;

    [SerializeField] List<TextMeshProUGUI> scoreboard = new(3);

    public delegate void OnScore();
    public static event OnScore OnScoreEvent;

    private void Awake()
    {
        saver = GetComponent<Saver>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CountUp();
    }

    private void OnEnable()
    {
        scrdata.HiScore = saver.LoadScores().HiScore;
        highScore = scrdata.HiScore;
        Scored.GoalScored += RecordAndUpdateScoreboard;
        Ball.BallEvent += BallCounter;
        Levels.OnLevelLoad += InitScoreboard;
    }

    private void OnDisable()
    {
        saver.SavetoJson(scrdata);
        Scored.GoalScored -= RecordAndUpdateScoreboard;
        Ball.BallEvent -= BallCounter;
        Levels.OnLevelLoad -= InitScoreboard;
    }

    void InitScoreboard()
    {
        foreach (var entry in scoreboard)
            entry.text = 0.ToString();

        StartCoroutine(nameof(BonusReduction));
    }

    void BallCounter()
    {

    }

    void CountUp()
    {
        if(Levels.IsLevelLoaded == true)
        {
            timer += Time.deltaTime;
            //DisplayTime(timer);
        }
    }
    IEnumerator BonusReduction()
    {
        do
        {
            LevelReporting.bonus -= 0.1f;
        }while(LevelReporting.bonus > 1);

        print("Bonus: "+LevelReporting.bonus);
        yield return new WaitForSeconds(6.9f);
    }

    void DisplayTime(float timer)
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        scoreboard[2].text = string.Format("{0}:{1:00}", minutes, seconds);
    }

/* SCORING */

    void RecordAndUpdateScoreboard()
    {
        ScorePerGoal();
        RecordScores();
        scoreboard[0].text = highScore.ToString();
        scoreboard[1].text = totalScore.ToString();

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
        score = (int)(_score * LevelReporting.bonus);

        return score;
    }

}

