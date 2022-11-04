using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public delegate void OnGoal();
    public static event OnGoal OnGoalEvent;

    public static void OnGoalTrigger()
    {
        if (OnGoalEvent != null)
            OnGoalEvent();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
