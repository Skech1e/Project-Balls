using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Levels : MonoBehaviour
{
    [SerializeField] protected bool isUnlocked;
    [SerializeField] int Arena, Levelno;
    Image LevelIcon;
    [SerializeField] List<Sprite> IconList = new();

    delegate void LevelUnlock();
    event LevelUnlock OnUnlock;

    private void Awake()
    {
        Levelno = int.Parse(name);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Unlock()
    {
        LevelIcon.sprite = IconList[1];
    }
}
