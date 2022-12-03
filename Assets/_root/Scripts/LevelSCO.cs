using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreData", menuName = "SCObj/LevelSCObj" )]
public class LevelSCO : ScriptableObject
{
    public Arena[] arenas = new Arena[10];
    
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
    public string name;
    public int levelid, hiscore, ballCount;
    public float timeTaken;
}
