using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{
    [SerializeField] private ScoreData _scores = new ScoreData();

    public void SavetoJson()
    {
        string score = JsonUtility.ToJson(_scores);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/usr/scglobal.json", score);
        print("data saved successfully");
    }

    public void LoadfromJson()
    {
        
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
