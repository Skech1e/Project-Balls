using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Scoring")]
    [SerializeField] protected int highScore, totalScore;
    [SerializeField] protected float timer, execTimer;
    [SerializeField][Range(3,9)] int ball_count;
    public static int score;


    private readonly ScoreData scrdata = new();
    private Saver saver;

    [SerializeField] List<TextMeshProUGUI> scoreboard = new(5);
    string[] scbnames = new string[5];

    public delegate void OnScore();
    public static event OnScore OnScoreEvent;

    private void Awake()
    {
        saver = GetComponent<Saver>();
        for(int i = 0; i < scbnames.Length; i++)
        {
            scbnames[i] = "scb" + i;
            print(scbnames[i]);
        }
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
        Ball.BallEvent += BallCounter;
        //Levels.OnLevelLoad += InitScoreboard;
    }

    private void OnDisable()
    {
        saver.SavetoJson(scrdata);
        Scored.GoalScored -= RecordAndUpdateScoreboard;
        Ball.BallEvent -= BallCounter;
        //Levels.OnLevelLoad -= StartCoroutine(nameof(InitScoreboard));
    }

    IEnumerator InitScoreboard()
    {
        yield return new WaitForSeconds(0.2f);
        print(GameObject.FindGameObjectWithTag("scb3"));
        for (int i = 0; i < scoreboard.Capacity; i++)
            scoreboard[i] = GameObject.FindGameObjectWithTag(scbnames[i]).GetComponent<TextMeshProUGUI>();

        foreach (var entry in scoreboard)
            entry.text = 0.ToString();
    }

    void BallCounter()
    {

    }

    void CountUp()
    {
        if(Levels.IsLevelLoaded == true)
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
    }

/* SCORING */

    void RecordAndUpdateScoreboard()
    {
        ScorePerGoal();
        RecordScores();
        scoreboard[0].text = highScore.ToString();
        scoreboard[1].text = totalScore.ToString();
        scoreboard[2].text = LevelReporting.bonus.ToString();
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

