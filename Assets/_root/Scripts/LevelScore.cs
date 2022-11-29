using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UserData", menuName = "ScriptableObjects/User Data ", order = 1)]
public class LevelScore : ScriptableObject
{
    public int[,] Level = new int[10, 16];
    public string levelname;

    public Arenas[] mArrays = new Arenas[10];

}
[System.Serializable]
public class Arenas
{
    public int[] levels = new int[16];
}

