using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] List<Scene> SceneList = new();

    private void OnEnable()
    {
        DontDestroyOnLoad(this);
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadSceneSnow()
    {
        SceneManager.LoadScene("SnowLevel");
    }
    public void LoadSceneDesert()
    {
        SceneManager.LoadScene("DesertLevel");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void SceneLoad(int sceneNumber, int level)
    {
        SceneManager.LoadScene(sceneNumber);
        GameObject.Find(nameof(level));
    }
}
