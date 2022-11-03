using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{


    public void LoadScene1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadSceneSnow()
    {
        SceneManager.LoadScene("SnowLevel");
    }
    public void LoadSceneDesert()
    {
        SceneManager.LoadScene("DesertLevel");
    }
}
