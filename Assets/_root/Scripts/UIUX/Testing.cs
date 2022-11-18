using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public List<NestedList> nestedLists = new List<NestedList>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Serializable]
    public class NestedList
    {
        public List<Levels> list = new();
    }
}
