using UnityEditor.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] bool levelFinish, timeOver;
    [SerializeField] int basketCount = 0, scoredBasketCount = 0;


    StageHandler stageHandler;
    public delegate void LevelHandler();
    public event LevelHandler LevelChanged;

    private void OnEnable()
    {
        LevelChanged += stageHandler.ChangeLevel;
    }

    private void OnDisable()
    {
        LevelChanged -= stageHandler.ChangeLevel;
    }

    private void Awake()
    {
        basketCount = transform.childCount;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LevelFinish()
    {

    }
    void TimeOver()
    {

    }
}
