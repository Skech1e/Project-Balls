using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Levels : MonoBehaviour
{
    [SerializeField] protected bool isUnlocked;
    [SerializeField] int Arena, lvlno;
    public static int Levelno, Arenano;
    public static bool IsLevelLoaded;

    Button Button;
    Image LevelIcon;
    [SerializeField] List<Sprite> IconList = new();
    [SerializeField] GameObject[] IconScore;

    SceneLoader SceneLoader;
    GameManager gameManager;

    private Saver saver;
    //[SerializeField] ScriptableObject UserLevelData;

    private void Awake()
    {
        IconScore = new GameObject[2];
        LevelIcon = GetComponent<Image>();
        Button = GetComponent<Button>();
        gameManager = FindObjectOfType<GameManager>();
        /*LevelIcon.sprite = isUnlocked == true ? IconList[1] : IconList[0];
        Button.interactable = isUnlocked == true ? true : false;*/
        //Unlock();
        for (int i = 0; i < 2; i++)
            IconScore[i] = transform.GetChild(i).gameObject;

        SceneLoader = FindObjectOfType<SceneLoader>();

        Button.onClick.AddListener(() => LoadLevel());
    }

    private void OnValidate()
    {
        /*LevelIcon = GetComponent<Image>();
        Button = GetComponent<Button>();
        LevelIcon.sprite = Unlocked == true ? IconList[1] : IconList[0];
        Button.interactable = Unlocked == true ? true : false;*/
    }

    private void OnEnable()
    {
        PlayPageUI.updateIcons += Unlock;
    }

    private void OnDisable()
    {
        PlayPageUI.updateIcons -= Unlock;
    }

    // Start is called before the first frame update
    void Start()
    {
        LevelIcon = GetComponent<Image>();
        Button = GetComponent<Button>();
        lvlno = int.Parse(name);
        Arenano = Arena;
        saver = GameManager.saver;
        //saver.LoadfromJson(saver);
        //isUnlocked = saver.arenas[Arena].levels[lvlno - 1].Unlocked;
        Unlock();
        LoadIconStats();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadIconStats()
    {
        var stars = saver.scoredata.arenas[Arena].levels[lvlno - 1].starCount;
        switch (stars)
        {
            case 0:
                break;
            case 1:
                IconScore[0].SetActive(true);
                break;
            case 2:
                IconScore[0].SetActive(false);
                IconScore[1].SetActive(true);
                break;
            case 3:
                IconScore[0].SetActive(true);
                IconScore[1].SetActive(true);
                break;
        }
    }

    void Unlock()
    {
        isUnlocked = saver.scoredata.arenas[Arena].levels[lvlno - 1].Unlocked;
        LevelIcon.sprite = isUnlocked == true ? IconList[1] : IconList[0];
        Button.interactable = isUnlocked == true ? true : false;
    }
    void LoadLevel()
    {
        Levelno = int.Parse(name);
        Arenano = Arena;
        lvlno = Levelno;
        IsLevelLoaded = true;
        SceneLoader.SceneLoad(Arena + 1, Levelno);
    }
}
