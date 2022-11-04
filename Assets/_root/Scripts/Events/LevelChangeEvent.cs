using UnityEngine;

public class LevelChangeEvent : StageHandler
{
    [SerializeField] Scored scored;

    private void Awake()
    {
        scored = FindObjectOfType<Scored>();
    }


    private void Start()
    {
        scored.LevelChanged += ChangeLevel;
    }

    private void OnEnable()
    {
        scored.LevelChanged += ChangeLevel;
    }

    private void OnDisable()
    {
        scored.LevelChanged -= ChangeLevel;
    }
}
