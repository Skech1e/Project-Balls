using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject mainMenu, pages;
    [SerializeField] List<GameObject> pagesList = new();

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

    public void OpenPages()
    {
         
    }
    
    public void Apply()
    {

    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
