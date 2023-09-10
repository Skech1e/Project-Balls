using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scored : MonoBehaviour
{
    [SerializeField] public int totalScore;
    [SerializeField] int score;
    bool goal;
    BoxCollider bc;
    [SerializeField] TextMeshProUGUI scoreTextPopup;
    Vector3 initScoreTextPosition, TargetScoreTextPosition;
    [SerializeField] GameObject basket;
    public Scored[] basketCount;

    public delegate void OnGoal();
    public static event OnGoal GoalScored;

    [SerializeField] ParticleSystem glow, glitter;

    private void Awake()
    {
        bc = GetComponent<BoxCollider>();
        initScoreTextPosition = scoreTextPopup.transform.localPosition;
        TargetScoreTextPosition = new Vector3(initScoreTextPosition.x, initScoreTextPosition.y + 6.9f, initScoreTextPosition.z);
        scoreTextPopup.gameObject.SetActive(false);

        basket.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        glow.Stop();
        glitter.Stop();
    }

    private void OnEnable()
    {
        basketCount = FindObjectsOfType<Scored>(false);
        

    }

    private void OnDisable()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        ScoreTextMotion();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            score = LevelReporting.ScorePerBasket;
            totalScore += score;
            goal = true;
            glow.Play();
            glitter.Play();
            Invoke(nameof(InvokeGoalScoredEvent), 0.5f);
        }
    }

    void InvokeGoalScoredEvent()
    {
        //CancelInvoke();
        GoalScored.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        bc.enabled = false;
        Invoke(nameof(Cheer), 1f);
    }

    void Cheer()
    {
        scoreTextPopup.transform.localPosition = initScoreTextPosition;
        scoreTextPopup.gameObject.SetActive(false);
        scoreTextPopup.alpha = 1f;
        goal = false;
        basket.SetActive(false);
        //print(basket.name+" basket");
    }

    void ScoreTextMotion()
    {
        if(goal == true)
        {
            scoreTextPopup.text = score.ToString();
            scoreTextPopup.gameObject.SetActive(true);
            var pos = scoreTextPopup.transform.localPosition;
            scoreTextPopup.transform.localPosition = Vector3.MoveTowards(pos, TargetScoreTextPosition, Time.deltaTime);
            scoreTextPopup.alpha -= Time.deltaTime * 1.69f;            
        }
        
    }


}
