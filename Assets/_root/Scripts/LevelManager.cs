using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int currentArena, currentLevel, ballCount;
    [SerializeField] int LevelCapacity;
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
        for (int i = 1; i < LevelCapacity  ; i++)
            levels.Add(transform.GetChild(i-1));
    }

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = Levels.Levelno - 1;  
        levels[currentLevel].gameObject.SetActive(true);
        ResetCount();
    }

    // Update is called once per frame
    void Update()
    {
        
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
