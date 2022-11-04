using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    
    bool flip;

    private void Awake()
    {
        //pages.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Close()
    {
        transform.parent.gameObject.SetActive(false);
        //var g = GetComponent<UIComponent>();
        //print(g.name + "\n" + g.transform.parent.name);
    }

    public void Apply()
    {

    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
