using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class LevelReporting : MonoBehaviour
{
    static Basket[] basketCount;
    [SerializeField] Basket[] basketCountIns;

    public static float bonus;
    enum BallCountEnum: int 
    {
        Three = 3, Six = 6, Nine = 9
    }

    [SerializeField] BallCountEnum _BallCount;

    public static int ballCount;
    public static int goalCount, ScorePerBasket;

    enum Scorepergoal: int
    {
        Hundred = 100,
        One_Fifty = 150,
        Two_Hundred = 200,
        Two_Fifty = 250,
        Three_Hundred = 300
    }
    [SerializeField] Scorepergoal sc;


    public delegate void OnGoalReport();
    public static event OnGoalReport LevelComplete;
    public static event OnGoalReport LevelReset;
    public static event OnGoalReport LevelFailed;

    private void OnEnable()
    {
        Scored.GoalScored += GoalTracker;
        Scored.GoalScored += UpdateScores;

        UIController.OnUIEvent += ResetLevel;
        Ball.BallEvent += BallLivesTracker;
    }
    private void OnDisable()
    {
        Scored.GoalScored -= GoalTracker;
        Scored.GoalScored -= UpdateScores;

        UIController.OnUIEvent -= ResetLevel;
        Ball.BallEvent -= BallLivesTracker;
    }


    // Start is called before the first frame update
    void Start()
    {
        ScorePerBasket = (int)sc;
        bonus = 2.0f;
        foreach(Transform child in transform)
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
        Start();
        Ball.resetBall = true;
        LevelReset.Invoke();
        Time.timeScale = 1;
        Scored.CancelInvokeMethod();
        Ball.CancelInvokeMethod();
    }


    void GoalTracker()
    {
        goalCount++;
        if (goalCount == basketCount.Length)
            LevelComplete.Invoke();
    }

    void BallLivesTracker()
    {
        ballCount--;
        if (ballCount == 0)
            LevelFailed.Invoke();
    }

    void UpdateScores()
    {

    }

    void RecordScoresToFile()
    {

    }

}
