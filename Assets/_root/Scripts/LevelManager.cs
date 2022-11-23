using System.Collections.Generic;
using System.Linq;
using UnityEditor.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] int basketCount;
    [SerializeField] int goalCount, currentLevel, LevelCapacity;
    List<Transform> levels = new();


    public delegate void LevelFinish();
    public static event LevelFinish OnLevelFinish;
    public static event LevelFinish OnLevelLoad;


    private void OnEnable()
    {
        Scored.GoalScored += GoalTracker;
    }

    private void OnDisable()
    {
        Scored.GoalScored -= GoalTracker;
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

    void TimeOver()
    {

    }

    void GoalTracker()
    {
        goalCount++;
        basketCount = LevelReporting.basketCount.Length;
        if (goalCount >= basketCount)
            OnLevelFinish.Invoke();
    }

    public void ChangeLevel()
    {
        levels[currentLevel].gameObject.SetActive(false);
        currentLevel++;
        levels[currentLevel].gameObject.SetActive(true);
        ResetCount();
        OnLevelLoad.Invoke();
        Time.timeScale = 1;
    }

    void ResetCount()
    {
        goalCount = 0;
        basketCount = FindObjectOfType<Scored>(false).basketCount.Length;
    }
}
