using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] List<Transform> ArenaList = new();
    public int loadLevel = -1;   
    [SerializeField]GameObject test;

    private static SceneLoader staticSceneLoader;

    private void OnEnable()
    {
        DontDestroyOnLoad(this);
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
        loadLevel = 100;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void SceneLoad(int sceneNumber, int _loadLevel)
    {
        //if(SceneManager.GetActiveScene().buildIndex != 0)
        SceneManager.LoadScene(sceneNumber);
        loadLevel = _loadLevel - 1;
        
    }

    void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        test = GameObject.FindGameObjectWithTag("Level");
        test.transform.GetChild(loadLevel).gameObject.SetActive(true);
    }
}
