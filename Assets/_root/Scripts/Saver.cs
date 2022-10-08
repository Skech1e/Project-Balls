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

    public ScoreData LoadfromJson()
    {
        string score = System.IO.File.ReadAllText(Application.persistentDataPath + "/scglobal.json");
        return JsonUtility.FromJson<ScoreData>(score);

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
}

[System.Serializable]
public class Inventory
{
    public string id;
    public string name;
    public int price;
}
