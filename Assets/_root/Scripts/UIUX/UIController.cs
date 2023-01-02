using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject Panel, LevelCompleteUI, LevelFailedUI, Buttons, Pause;

    [SerializeField] LevelCompleteUI levelfinishbox;
    [SerializeField] Image[] Stars = new Image[3];

    public delegate void UIControl();
    public static event UIControl OnRestartfromUI;

    SceneLoader sceneLoader;

    private void OnEnable()
    {
        LevelReporting.LevelComplete += LevelFinished;
        LevelReporting.LevelFailed += LevelFailed;
    }

    private void OnDisable()
    {
        LevelReporting.LevelComplete -= LevelFinished;
        LevelReporting.LevelFailed -= LevelFailed;
        for (int i = 0; i < Stars.Length; i++)
        {
            var temp = Stars[i].color;
            temp.a = 0f;
            Stars[i].color = temp;
        }
    }

    private void Awake()
    {
        //pages.SetActive(false);
        sceneLoader = FindObjectOfType<SceneLoader>();
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
        levelfinishbox.score.text = GameManager.totalScore.ToString();
        levelfinishbox.coins.text = levelfinishbox.score.text;

        Buttons.SetActive(false);
        Panel.SetActive(true);
        LevelCompleteUI.SetActive(true);
        DisplayStars();
        Time.timeScale = 0;
    }

    void DisplayStars()
    {
        for(int i = 0; i < GameManager.starCount; i++)
        {
            var temp = Stars[i].color;
            temp.a = 1f;
            Stars[i].color = temp;
        }
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
        //SceneManager.LoadScene(0);
        sceneLoader.SceneLoad(0, 0);
    }

    public void Restart()
    {
        OnRestartfromUI.Invoke();
        for (int i = 0; i < Stars.Length; i++)
        {
            var temp = Stars[i].color;
            temp.a = 0f;
            Stars[i].color = temp;
        }
    }
}
