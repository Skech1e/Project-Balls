using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] List<Transform> ArenaList = new();
    public int loadLevel = -1;

    private static SceneLoader staticSceneLoader;

    [SerializeField] GameObject cameraRotator, LoadingScreenPanel;
    [SerializeField] TextMeshProUGUI progressText;
    public delegate void OnSceneLoadDelegate();
    public static event OnSceneLoadDelegate SceneLoaded;

    private void OnEnable()
    {
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(cameraRotator);
        DontDestroyOnLoad(LoadingScreenPanel);
        SceneManager.sceneLoaded += OnSceneLoad;

        if(staticSceneLoader == null)
            staticSceneLoader = this;
        else
            Destroy(gameObject);
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoad;
    }

    private void Update()
    {
        
    }
    private void Start()
    {
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void SceneLoad(int sceneNumber, int _loadLevel)
    {
        StartCoroutine(LoadSceneAsync(sceneNumber));
        loadLevel = _loadLevel - 1;
    }

    IEnumerator LoadSceneAsync(int sceneNumber)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneNumber);
        LoadingScreenPanel.SetActive(true);
        while (!operation.isDone)
        {
            System.GC.Collect();
            progressText.text = (operation.progress * 100).ToString("F0") + "%";
            yield return null;
        }
        LoadingScreenPanel.SetActive(false);
    }

    void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        SceneLoaded.Invoke();       
    }
}
