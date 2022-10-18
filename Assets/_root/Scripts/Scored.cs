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
    GameManager gameManager;
    StageHandler stageHandler;

    private void Awake()
    {
        bc = GetComponent<BoxCollider>();
        gameManager = FindObjectOfType<GameManager>();
        stageHandler = FindObjectOfType<StageHandler>();
        initScoreTextPosition = scoreTextPopup.transform.localPosition;
        TargetScoreTextPosition = new Vector3(initScoreTextPosition.x, initScoreTextPosition.y + 6.9f, initScoreTextPosition.z);
        scoreTextPopup.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        GameEvents.OnGoalEvent += ScoreTextMotion;
    }

    private void OnDisable()
    {
        GameEvents.OnGoalEvent -= ScoreTextMotion;
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
            score = gameManager.ScorePerGoal();
            totalScore += score;
            goal = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        bc.enabled = false;
        Invoke(nameof(Cheer), 1f);
    }

    void Cheer()
    {
        stageHandler.loadNext = true;
        scoreTextPopup.transform.localPosition = initScoreTextPosition;
        scoreTextPopup.gameObject.SetActive(false);
        scoreTextPopup.alpha = 1f;
        goal = false;
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
