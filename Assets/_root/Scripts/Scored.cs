using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scored : MonoBehaviour
{
    [ReadOnlyProperty] public int totalScore, highscore;
    [SerializeField] int timer;
    [SerializeField] int score = 69, bonus;

    [SerializeField] List<TextMeshProUGUI> scoreboard = new(3);

    BoxCollider bc;

    private void Awake()
    {
        bc = GetComponent<BoxCollider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (var entry in scoreboard)
            entry.text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            totalScore += score + bonus;
            UpdateScoreBoard();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        bc.enabled = false;
    }

    void UpdateScoreBoard()
    {
        scoreboard[0].text = highscore.ToString();
        scoreboard[1].text = totalScore.ToString();
        //scoreboard[2].text = timer.ToString();
    }
}
