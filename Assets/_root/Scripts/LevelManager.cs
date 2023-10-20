using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int currentArena, currentLevel, ballCount;
    [SerializeField] int LevelCapacity, currentlvl;
    [SerializeField] List<Transform> levels = new();
    SceneLoader sceneLoader;
    Saver saver;
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
        for (int i = 0; i < LevelCapacity; i++)
            levels.Add(transform.GetChild(i));
    }

    // Start is called before the first frame update
    void Start()
    {
        currentArena = Levels.Arenano;
        currentLevel = Levels.Levelno - 1;
        levels[currentLevel].gameObject.SetActive(true);
        ResetCount();
        sceneLoader = FindObjectOfType<SceneLoader>();
        saver = GameManager.saver;
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
        if (currentLevel < 15)
        {
            levels[currentLevel].gameObject.SetActive(false);
            currentLevel++;
            levels[currentLevel].gameObject.SetActive(true);
        }
        else
        {
            if (saver.scoredata.arenas[currentArena + 1].unlocked == true && currentArena < 4)
            {
                Levels.Arenano++;
                Levels.Levelno = 1;
                sceneLoader.SceneLoad(currentArena + 2, currentLevel);
            }
        }

        Ball.resetBall = true;
        ResetCount();
        Time.timeScale = 1;
    }

    void ResetCount() => LevelReporting.goalCount = 0;
}
