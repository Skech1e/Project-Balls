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
    GameManager gameManager;
    StageHandler stageHandler;

    private void Awake()
    {
        bc = GetComponent<BoxCollider>();
        gameManager = FindObjectOfType<GameManager>();
        stageHandler = FindObjectOfType<StageHandler>();
        scoreTextPopup.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
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
            score = gameManager.ScorePerGoal();
            totalScore += score;
            goal = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        bc.enabled = false;
        ScoreTextMotion();
        //Invoke(nameof(Cheer), 0.3f);
    }

    void Cheer()
    {
        stageHandler.loadNext = true;
    }

    void ScoreTextMotion()
    {
        if(goal == true)
        {
            scoreTextPopup.gameObject.SetActive(true);
            var pos = scoreTextPopup.transform.position;
            scoreTextPopup.transform.position = Vector3.MoveTowards(pos, new Vector3(pos.x, pos.y + 12f, pos.z), Time.deltaTime);
            //goal = false;
        }
        
    }

}
