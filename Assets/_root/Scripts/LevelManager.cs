using System.Collections.Generic;
using System.Linq;
using UnityEditor.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] int currentLevel, LevelCapacity;
    List<Transform> levels = new();

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
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

    public void ChangeLevel()
    {
        levels[currentLevel].gameObject.SetActive(false);
        currentLevel++;
        levels[currentLevel].gameObject.SetActive(true);

        LevelReporting.goalCount = 0;
        Time.timeScale = 1;
    }

    void ResetCount()
    {
        LevelReporting.goalCount = 0;
    }
}
