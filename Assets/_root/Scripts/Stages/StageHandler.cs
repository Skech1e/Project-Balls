using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;

public class StageHandler : MonoBehaviour
{

    [SerializeField] List<Transform> level, level2, level3 = new();
    [SerializeField] List<UnityEvent> lvChangeEvent = new();
    [SerializeField] List<Scored> basket = new();
    [SerializeField] PositionsArray pa;

    public bool loadNext;
    public int currentLevel;

    [Header("Debug")]
    [SerializeField] ArrayViewer av;
    public bool test;
    public int count;
    enum LevelType { still, moving }

    LevelType leveltype = new LevelType();

    [SerializeField] Queue<int> istack, jstack;

    private void Awake()
    {
        basket.Capacity = 4;
        istack = new Queue<int>();
        jstack = new Queue<int>();

        for (int i = 1; i < basket.Capacity; i++)
            basket[i].transform.parent.gameObject.SetActive(false);

        LevelInit();
    }

    private void Update()
    {
        if (loadNext == true)
            LevelChange();

        basket[0].transform.parent.position = Vector3.MoveTowards(basket[0].transform.parent.position, level[currentLevel].position, Time.deltaTime*5);
    }

    void LevelInit()
    {
            
    }

    void LevelChange()
    {
        currentLevel++;
        loadNext = false;
    }

    public void Check()
    {
        count = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (av.columns[i].rows[j] == true)
                {
                    istack.Enqueue(i);
                    jstack.Enqueue(j);
                    count++;
                    if (istack.Count > 3 && jstack.Count > 3)
                    {
                        av.columns[istack.ElementAt(0)].rows[jstack.ElementAt(0)] = false;
                        istack.Dequeue();
                        jstack.Dequeue();

                    }
                    basket[count].transform.parent.position = pa.target[i, j].position;
                    //basket.transform.parent.position += Vector3.back * offset;
                }
            }
        }


        switch (leveltype)
        {
            case LevelType.still:

                break;
            case LevelType.moving:
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }




    /*[CustomEditor(typeof(StageHandler))]
    public class StackViewer : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();


            var ts = (StageHandler)target;
            var iStack = ts.istack;
            var jStack = ts.jstack;


            foreach (var item in iStack)
                GUILayout.Label("I: " + item.ToString());

            foreach (var item in jStack)
                GUILayout.Label("J: " + item.ToString());
        }


    }*/
}