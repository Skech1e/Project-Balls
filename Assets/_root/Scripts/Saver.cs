using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "UserData", menuName = "SCObj/Saver")]
public class Saver : ScriptableObject
{
    public Arena[] arenas = new Arena[10];

    //[SerializeField] private ScoreData _scores = new ScoreData();
    string scpath, cfgpath;

    private void Awake()
    {
        scpath = Path.Combine(Application.persistentDataPath, "scglobal.json");
        cfgpath = Path.Combine(Application.persistentDataPath, "cb_usr.json");       
    }

    private void OnValidate()
    {
        int i = 1; int j = 1;
        foreach (Arena arena in arenas)
        {
            arena.name = "Arena " + i;
            i = i < 10 ? (i + 1) : 1;
            foreach (Level level in arena.levels)
            {
                level.name = "Level " + j;
                j = j < 16 ? (j + 1) : 1;
            }
        }
    }

    public void SavetoJson(Saver _score)
    {
        string score = JsonUtility.ToJson(_score);
        File.WriteAllText(scpath, score);
        Debug.Log("data saved successfully");
    }

    public Saver LoadfromJson()
    {
        string score = File.ReadAllText(scpath);
        Debug.Log("save loaded");
        return JsonUtility.FromJson<Saver>(score);
    }

    public void SavetoJson(UserData _user)
    {
        string user = JsonUtility.ToJson(_user);
        File.WriteAllText(cfgpath, user);
        Debug.Log("user config saved");
    }

    public UserData LoadUser()
    {
        string user = File.ReadAllText(cfgpath);
        return JsonUtility.FromJson<UserData>(user);
    }
}

[System.Serializable]
public class ScoreData
{
    public string Name;
    public int HiScore;

    public struct LevelScores
    {
        public int ArenaID, levelID;
        public int Hiscore, ballCount;
        public float TimeTaken;
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

[System.Serializable]
public class UserData
{
    public string Name;
    public int level;
    public int balance;
    public List<Inventory> usr_inventory = new List<Inventory>();

    public bool Sound, Music;
    public int Graphics;
}

[System.Serializable]
public class Inventory
{
    public string id;
    public string name;
    public int price;
}
