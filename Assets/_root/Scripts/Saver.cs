using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


//[CreateAssetMenu(fileName = "UserData", menuName = "SCObj/Saver")]
public class Saver : ScriptableObject
{
    public Scores scoredata;
    public UserData usrdata;
    string scpath, datapath;

    private void Awake()
    {
        scpath = Path.Combine(Application.persistentDataPath, "scglobal.json");
        datapath = Path.Combine(Application.persistentDataPath, "cb_usr.json");

        LoadfromJson();
    }

    /*private void OnValidate()
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
    }*/
    
    public void SaveAll()
    {
        //Debug.Log("Everything saved");
        SavetoJson(scoredata);
        SavetoJson(usrdata);
    }

    public void SavetoJson(Scores s)
    {
        string score = JsonUtility.ToJson(s, true);
        File.WriteAllText(scpath, score);
        //Debug.Log("data saved successfully");
    }

    public void LoadfromJson()
    {
        string data = File.ReadAllText(scpath);
        if (data is null)
        {
            Debug.Log("No save found! Created.");
            SavetoJson(scoredata);
            SavetoJson(usrdata);
        }

        //Debug.Log("save loaded");
        JsonUtility.FromJsonOverwrite(data, this);
    }

    #region Userdata settings
    public void SavetoJson(UserData _user)
    {
        string user = JsonUtility.ToJson(_user, true);
        File.WriteAllText(datapath, user);
        //Debug.Log("user config saved");
    }

    public UserData LoadUser()
    {
        string user = File.ReadAllText(datapath);
        //Debug.Log("Usr data loaded");
        return JsonUtility.FromJson<UserData>(user);
    }
    #endregion

    /*#region Inventory
    public void SavetoJson(Inventory _inv)
    {
        string inv = JsonUtility.ToJson(_inv);
        File.WriteAllText(datapath, inv);
        //Debug.Log("inventory saved");
    }

    public Inventory LoadInventory()
    {
        string inventory = File.ReadAllText(datapath);
        //Debug.Log("Inventory Loaded");
        return JsonUtility.FromJson<Inventory>(inventory);
    }
    #endregion*/
}

[System.Serializable]
public class Scores
{
    public Arena[] arenas = new Arena[10];
}

[System.Serializable]
public class UserData
{
    public Settings settings = new();
    public Inventory inventory = new();
}

[System.Serializable]
public class Arena
{
    public string name;
    public int starPrice, coinPrice;
    public bool unlocked;
    public Level[] levels = new Level[16];
}

[System.Serializable]
public class Level
{
    public bool Unlocked;
    public string name = "Level";
    public int levelid, hiscore, ballCount, starCount, coins_earned;
    public float timeTaken;
}

[System.Serializable]
public class Settings
{
    public string Name;
    public bool Sound, Music;
}

[System.Serializable]
public class Inventory
{
    public int balance, starbalance;
    public byte active_skin;
    public List<byte> skinList;
}
