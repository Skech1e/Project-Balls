using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject Panel, LevelCompleteUI;

    private void OnEnable()
    {
        StageHandler.OnLevelFinish += LevelFinished;
    }

    private void OnDisable()
    {
        StageHandler.OnLevelFinish -= LevelFinished;
    }

    private void Awake()
    {
        //pages.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Close()
    {
        transform.parent.gameObject.SetActive(false);
    }

    public void Apply()
    {

    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void PauseMenu()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void Levels()
    {
        //Time.timeScale = 1;
    }

    public void LevelFinished()
    {
        Panel.SetActive(true);
        LevelCompleteUI.SetActive(true);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

}
