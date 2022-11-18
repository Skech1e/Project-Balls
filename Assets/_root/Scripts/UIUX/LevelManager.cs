using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //[SerializeField] List<Arena> Arenas = new();
    [SerializeField] List<Levels> Arena1 = new();
    [SerializeField] List<Levels> Arena2 = new();
    [SerializeField] List<Levels> Arena3 = new();
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [System.Serializable]
    public class Arena
    {
        //[SerializeField] List<Levels> levels = new();
        public List<Level> arena = new();
        public List<Level> arena2 = new();
        public List<Levels> arena3 = new();

        [System.Serializable]
        public class Level
        {
            public List<Levels> Levels = new();
        }
    }
}
