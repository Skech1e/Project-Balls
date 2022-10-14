using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scored : MonoBehaviour
{
    [SerializeField] public int totalScore;
    [SerializeField] int score;
    BoxCollider bc;
    GameManager gameManager;
    StageHandler stageHandler;

    private void Awake()
    {
        bc = GetComponent<BoxCollider>();
        gameManager = FindObjectOfType<GameManager>();
        stageHandler = FindObjectOfType<StageHandler>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            score = gameManager.ScorePerGoal();
            totalScore += score;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        bc.enabled = false;
        Invoke(nameof(Cheer), 0.3f);
    }

    void Cheer()
    {
        stageHandler.loadNext = true;
    }

}
