using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class LevelReporting : MonoBehaviour
{
    static Basket[] basketCount;
    [SerializeField] Basket[] basketCountIns;

    public static int Levelnumber;
    public static float bonus;
    enum BallCountEnum : int
    {
        Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9
    }

    [SerializeField] BallCountEnum _BallCount;

    public static int ballCount;
    public static int goalCount, ScorePerBasket;

    enum Scorepergoal : int
    {
        Seventy_Five = 75,
        Hundred = 100,
        One_Fifty = 150,
        Two_Hundred = 200,
        Two_Fifty = 250,
        Three_Hundred = 300
    }
    [SerializeField] Scorepergoal sc;

    enum ScoringTier : int
    {
        Five = 5,
        Seven = 7,
        Ten = 10,
        Twelve = 12,
        Thirteen = 13,
        Fifteen = 15,
        Seventeen = 17,
        Eighteen = 18,
        Twenty = 20
    }
    [SerializeField] ScoringTier[] scTier;

    public delegate void OnGoalReport();
    public static event OnGoalReport LevelComplete;
    public static event OnGoalReport LevelFailed;
    public delegate void OnLevelLoad();
    public static event OnLevelLoad LevelLoad;

    private void OnEnable()
    {
        Levelnumber = int.Parse(name);
        LevelManager.currentLevel = Levelnumber - 1;

        for (int i = 0; i < scTier.Length; i++)
            GameManager.scoreTier[i] = (int)scTier[i];

        Ball.BallEvent += BallLivesTracker;
        ResetLevel();
        Scored.GoalScored += GoalTracker;

        UIController.OnRestartfromUI += ResetLevel;
    }
    private void OnDisable()
    {
        LevelManager.ballCount = ballCount;

        Scored.GoalScored -= GoalTracker;

        UIController.OnRestartfromUI -= ResetLevel;
        Ball.BallEvent -= BallLivesTracker;

    }


    // Start is called before the first frame update
    void Start()
    {
        ScorePerBasket = (int)sc;
        bonus = 2.0f;
        foreach (Transform child in transform)
            child.gameObject.SetActive(true);

        basketCount = FindObjectsOfType<Basket>(false);
        //foreach (Basket basket in basketCount)
        //    basket.gameObject.SetActive(true);

        ballCount = (int)_BallCount;
        goalCount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        basketCountIns = basketCount;
    }

    void ResetLevel()
    {
        FindObjectOfType<Scored>()?.CancelInvoke();
        FindObjectOfType<Ball>()?.CancelInvoke();
        Time.timeScale = 1;
        ballCount = (int)_BallCount;
        Start();
        Ball.resetBall = true;
        LevelLoad.Invoke();
    }


    void GoalTracker()
    {
        goalCount++;
        if (goalCount == basketCount.Length)
            Result(true);
    }

    void BallLivesTracker()
    {
        ballCount--;
        if (ballCount == 0 && goalCount != basketCount.Length)
            Result(false);
    }

    void Result(bool win)
    {
        if(win)
        {
            StartCoroutine(Pass());
            IEnumerator Pass()
            {
                yield return new WaitForSeconds(1.8f);
                LevelComplete.Invoke();
            }
        }
        else
        {
            StartCoroutine(Fail());
            IEnumerator Fail()
            {
                yield return new WaitForSeconds(0f);
                LevelFailed.Invoke();
            }
        }
    }

}
