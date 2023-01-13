using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Levels : MonoBehaviour
{
    [SerializeField] protected bool isUnlocked;
    [SerializeField] int Arena, lvlno;
    public static int Levelno;
    public static bool IsLevelLoaded;

    Button Button;
    Image LevelIcon;
    [SerializeField] List<Sprite> IconList = new();
    [SerializeField] GameObject[] IconScore;

    SceneLoader SceneLoader;

    private Saver saver;
    //[SerializeField] ScriptableObject UserLevelData;

    private void Awake()
    {
        LevelIcon = GetComponent<Image>();
        IconScore = new GameObject[2];
        LevelIcon.sprite = isUnlocked == true ? IconList[1] : IconList[0];
        for (int i = 0; i < 2; i++)
            IconScore[i] = transform.GetChild(i).gameObject;

        Button = GetComponent<Button>();
        Button.interactable = isUnlocked == true ? true : false;
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

    }

    private void OnDisable()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        lvlno = int.Parse(name);
        saver = FindObjectOfType<Saver>();
        saver.LoadfromJson();
        isUnlocked = saver.arenas[Arena].levels[lvlno - 1].Unlocked;
        Unlock();
        LoadIconStats();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadIconStats()
    {
        var stars = saver.arenas[Arena].levels[lvlno - 1].starCount;
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
        LevelIcon = GetComponent<Image>();
        Button = GetComponent<Button>();
        LevelIcon.sprite = isUnlocked == true ? IconList[1] : IconList[0];
        Button.interactable = isUnlocked == true ? true : false;
    }
    void LoadLevel()
    {
        Levelno = int.Parse(name);
        lvlno = Levelno;
        IsLevelLoaded = true;
        SceneLoader.SceneLoad(Arena + 1, Levelno);
    }
}
