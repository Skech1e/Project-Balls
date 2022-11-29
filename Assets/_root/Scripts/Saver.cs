using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Saver : MonoBehaviour
{
    [SerializeField] private ScoreData _scores = new ScoreData();
    string scpath, cfgpath;

    private void Awake()
    {
        scpath = Path.Combine(Application.persistentDataPath, "scglobal.json");
        cfgpath = Path.Combine(Application.persistentDataPath, "cb_usr.json");
    }
    public void SavetoJson(ScoreData _score)
    {
        string score = JsonUtility.ToJson(_score);
        File.WriteAllText(scpath, score);
        print("data saved successfully");
    }

    public ScoreData LoadScores()
    {
        string score = File.ReadAllText(scpath);
        return JsonUtility.FromJson<ScoreData>(score);

    }

    public void SavetoJson(UserData _user)
    {
        string user = JsonUtility.ToJson(_user);
        File.WriteAllText(cfgpath, user);
        print("user config saved");
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
