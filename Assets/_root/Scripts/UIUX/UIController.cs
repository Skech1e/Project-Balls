using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject Panel, LevelCompleteUI, LevelFailedUI, Buttons, Pause;

    [SerializeField] LevelCompleteUI levelfinishbox;

    public delegate void UIControl();
    public static event UIControl OnUIEvent;

    private void OnEnable()
    {
        LevelReporting.LevelComplete += LevelFinished;
        LevelReporting.LevelFailed += LevelFailed;
    }

    private void OnDisable()
    {
        LevelReporting.LevelComplete -= LevelFinished;
        LevelReporting.LevelFailed -= LevelFailed;
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

    public void NextLevel()
    {
        //Time.timeScale = 1;
    }

    public void LevelFinished()
    {
        levelfinishbox.score.text = GameManager.score.ToString();
        levelfinishbox.coins.text = levelfinishbox.score.text;

        Buttons.SetActive(false);
        Panel.SetActive(true);
        LevelCompleteUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void LevelFailed()
    {
        Buttons.SetActive(false);
        Panel.SetActive(true);
        LevelFailedUI.SetActive(true);  
        Time.timeScale = 0;
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        OnUIEvent.Invoke();
    }
}
