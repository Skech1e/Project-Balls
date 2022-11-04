using UnityEngine;

public class GoalEvent : MonoBehaviour
{
    public delegate void GoalEventHandler();
    public GoalEventHandler Goaled;
}
