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

    delegate void LevelUnlock();
    event LevelUnlock OnUnlock;

    SceneLoader SceneLoader;

    private Saver saver;
    [SerializeField] ScriptableObject UserLevelData;

    private void Awake()
    {        
        LevelIcon = GetComponent<Image>();
        LevelIcon.sprite = isUnlocked == true ? IconList[1] : IconList[0];
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
        saver = UserLevelData as Saver;
        saver.LoadfromJson(saver);
        isUnlocked = saver.arenas[Arena].levels[lvlno-1].Unlocked;
        Unlock();
    }

    // Update is called once per frame
    void Update()
    {

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
        IsLevelLoaded = true;
        SceneLoader.SceneLoad(Arena+1, Levelno);
    }
}
