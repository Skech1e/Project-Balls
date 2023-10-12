using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


//[CreateAssetMenu(fileName = "UserData", menuName = "SCObj/Saver")]
public class Saver : ScriptableObject
{
    public Arena[] arenas = new Arena[10];
    //[SerializeField] public Scores scores;
    public UserData usrdata;
    public Inventory inventory;
    string scpath, cfgpath;

    private void Awake()
    {

        scpath = Path.Combine(Application.persistentDataPath, "scglobal.json");
        cfgpath = Path.Combine(Application.persistentDataPath, "cb_usr.json");

        LoadfromJson(this);
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

    /*public void SavetoJson(Scores _score)
    {
        Scores s = new();
        s.arenas = scores.arenas;

        string score = JsonUtility.ToJson(s, true);
        File.WriteAllText(scpath, score);
        Debug.Log("data saved successfully");
    }*/
    public void SavetoJson(Saver s)
    {
        string score = JsonUtility.ToJson(s, true);
        File.WriteAllText(scpath, score);
        Debug.Log("data saved successfully");
    }

    public void LoadfromJson(Saver s)
    {
        string score = File.ReadAllText(scpath);
        if (score is null)
        {
            Debug.Log("No save found! Created.");
            SavetoJson(this);
            SavetoJson(usrdata);
            SavetoJson(inventory);
            return;
        }

        Debug.Log("save loaded");
        JsonUtility.FromJsonOverwrite(score, s);
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
        Debug.Log("Usr data loaded");
        return JsonUtility.FromJson<UserData>(user);
    }

    public void SavetoJson(Inventory _inv)
    {
        string inv = JsonUtility.ToJson(_inv);
        File.WriteAllText(cfgpath, inv);
        Debug.Log("inventory saved");
    }

    public Inventory LoadInventory()
    {
        string inventory = File.ReadAllText(cfgpath);
        Debug.Log("Inventory Loaded");
        return JsonUtility.FromJson<Inventory>(inventory);
    }
}


[System.Serializable]
public class Scores
{
    public Arena[] arenas = new Arena[10];


    public override string ToString()
    {
        return arenas[0].name;
    }
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
public class UserData
{
    public string Name;
    public int balance, starbalance;
    public Skin active_skin;
    public bool Sound, Music;

}


[System.Serializable]
public class Inventory
{
    public List<Skin> skinList;
    public List<int> arenaID;
}
