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
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }
}
