using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReporting : MonoBehaviour
{
    public static Scored[] basketCount;

    // Start is called before the first frame update
    void Start()
    {
        basketCount = FindObjectsOfType<Scored>(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
