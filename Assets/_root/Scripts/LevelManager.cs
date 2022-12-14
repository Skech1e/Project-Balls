using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int currentArena, currentLevel, ballCount;
    [SerializeField] int LevelCapacity, ActiveArena, ActiveLevel;
    [SerializeField] List<Transform> levels = new();

    public delegate void OnLevelChange();
    public static OnLevelChange OnLevelChangeEvent;

    private void OnEnable()
    {
        Levels.OnLevelLoad += GetLevelInfo;
    }

    private void OnDisable()
    {
        Levels.OnLevelLoad -= GetLevelInfo;
    }

    private void Awake()
    {
        for (int i = 1; i < LevelCapacity  ; i++)
            levels.Add(transform.GetChild(i-1));
    }

    // Start is called before the first frame update
    void Start()
    {
        currentArena = ActiveArena;
        ActiveLevel = Levels.Levelno - 1;
        currentLevel = ActiveLevel;
        levels[ActiveLevel].gameObject.SetActive(true);
        ResetCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetLevelInfo()
    {
        currentLevel = Levels.Levelno - 1;
        print(currentLevel);
    }

    public void ChangeLevel()
    {
        levels[ActiveLevel].gameObject.SetActive(false);
        ActiveLevel++;
        currentLevel = ActiveLevel;
        levels[ActiveLevel].gameObject.SetActive(true);

        Ball.resetBall = true;
        OnLevelChangeEvent.Invoke();
        ResetCount();
        Time.timeScale = 1;
    }

    void ResetCount()
    {
        LevelReporting.goalCount = 0;
    }
}
