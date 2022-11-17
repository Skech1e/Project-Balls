using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{
    [SerializeField] private ScoreData _scores = new ScoreData();

    public void SavetoJson(ScoreData _score)
    {
        string score = JsonUtility.ToJson(_score);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/scglobal.json", score);
        print("data saved successfully");
    }

    public ScoreData LoadScores()
    {
        string score = System.IO.File.ReadAllText(Application.persistentDataPath + "/scglobal.json");
        return JsonUtility.FromJson<ScoreData>(score);

    }

    public void SavetoJson(UserData _user)
    {
        string user = JsonUtility.ToJson(_user);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/cb_usr.json", user);
        print("user config saved");
    }

    public UserData LoadUser()
    {
        string user = System.IO.File.ReadAllText(Application.persistentDataPath + "/cb_usr.json");
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
