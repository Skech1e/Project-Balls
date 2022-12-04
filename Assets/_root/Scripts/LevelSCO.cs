using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreData", menuName = "SCObj/LevelSCObj")]
public class LevelSCO : ScriptableObject
{
    public Arena[] arenas = new Arena[10];
    int i = 1;
    
    public void PrintMessage()
    {

    }
    private void OnValidate()
    {
        foreach(Arena arena in arenas)
        {
            foreach(Level level in arena.levels)
            {
                level.name = "Level " + i;
                i = i < 16 ? (i + 1) : 1;
            }
        }
    }
    private void Awake()
    {
        Debug.Log("awake");
    }

}

[System.Serializable]
public class Arena
{
    public string name;
    public Level[] levels = new Level[16];
}

[System.Serializable]
public class Level
{
    public string name = "Level";
    public int levelid, hiscore, ballCount;
    public float timeTaken;
}
