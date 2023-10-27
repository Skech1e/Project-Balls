using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System;
using TMPro;

public class PlayGames : MonoBehaviour
{
    public TextMeshProUGUI check;

    void Start()
    {
        PlayGamesPlatform.Activate();
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);

    }

    private void ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success) { check.text = "Success"; }
        else
            check.text = "Failed";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
