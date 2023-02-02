using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int currentArena, currentLevel, ballCount;
    [SerializeField] int LevelCapacity, currentlvl;
    [SerializeField] List<Transform> levels = new();

    private void OnEnable()
    {
        LevelReporting.LevelLoad += GetLevelInfo;
    }

    private void OnDisable()
    {
        LevelReporting.LevelLoad -= GetLevelInfo;
    }

    private void Awake()
    {
        for (int i = 0; i < LevelCapacity  ; i++)
            levels.Add(transform.GetChild(i));
    }

    // Start is called before the first frame update
    void Start()
    {
        currentArena = Levels.Arenano;
        currentLevel = Levels.Levelno - 1;  
        levels[currentLevel].gameObject.SetActive(true);
        ResetCount();
    }

    // Update is called once per frame
    void Update()
    {
        currentlvl = currentLevel;
    }

    void GetLevelInfo()
    {
        currentLevel = LevelReporting.Levelnumber - 1;
    }

    public void ChangeLevel()
    {
        levels[currentLevel].gameObject.SetActive(false);
        currentLevel++;
        levels[currentLevel].gameObject.SetActive(true);

        Ball.resetBall = true;
        ResetCount();
        Time.timeScale = 1;
    }

    void ResetCount()
    {
        LevelReporting.goalCount = 0;
    }
}
