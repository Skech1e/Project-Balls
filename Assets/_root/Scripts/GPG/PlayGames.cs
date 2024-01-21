using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using System;
using TMPro;
using System.IO;
using System.Text;

public class PlayGames : MonoBehaviour
{
    public static PlayGames playGames { get; private set; }
    public TextMeshProUGUI check, debug;
    string savepath;
    bool isOnline;
    private void Awake()
    {
        if (playGames == null)
            playGames = this;
        else
            Destroy(this);

        //savepath = Path.Combine(Application.persistentDataPath, "scglobal.json");
        savepath = "scglobal.json";
    }

    void Start()
    {
        isOnline = Application.internetReachability == NetworkReachability.NotReachable ? false : true;
        PlayGamesPlatform.Activate();
        if (isOnline)
            PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
        //check.text = "Start";
        //GameManager.saver.LoadfromJson();
    }

    public void ProcessAuthentication(SignInStatus status)
    {
        check.text = "entered";
        check.text = status.ToString();
        if (status == SignInStatus.Success)
        {
            check.text = "Success";
            OpenSavedGame(savepath);
        }
        else
            check.text = "Failed";
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OpenSavedGame(string filename)
    {
        check.text = "OpenSavedGame";
        ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
        savedGameClient.OpenWithAutomaticConflictResolution(filename, DataSource.ReadCacheOrNetwork,
            ConflictResolutionStrategy.UseLongestPlaytime, OnSavedGameOpened);
    }

    private void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata game)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            // handle reading or writing of saved game.
            check.text = "OnSavedGameOpened";
            //GameManager.saver = (Saver)game;
            //debug.text = game?.Filename;
            //check.text = "Save Loaded";

            string scjson = JsonUtility.ToJson(GameManager.saver.scoredata);
            check.text = "scoredata";
            string usrjson = JsonUtility.ToJson(GameManager.saver.usrdata);
            check.text = "before encoding";
            byte[] scdata = Encoding.UTF8.GetBytes(scjson);
            check.text = "scjson encoding";
            byte[] usrdata = Encoding.UTF8.GetBytes(usrjson);
            check.text = "before build";
            SavedGameMetadataUpdate.Builder builder = new SavedGameMetadataUpdate.Builder();
            check.text = "after builder inst";
            SavedGameMetadataUpdate update = builder.Build();
            check.text = "after build";
            ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
            check.text = "before commit";
            savedGameClient.CommitUpdate(game, update, usrdata, OnSavedGameWritten);
            check.text = "save commit";
            debug.text = game.ToString();
        }
        else
        {
            // handle error
            check.text = "Save Load Failed";
        }
    }

    void LoadGameData(ISavedGameMetadata game)
    {
        ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
        savedGameClient.ReadBinaryData(game, OnSavedGameDataRead);
    }

    public void OnSavedGameDataRead(SavedGameRequestStatus status, byte[] data)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            // handle processing the byte array data
            check.text = "Saved to Cloud";
        }
        else
        {
            // handle error
            check.text = "nope";
        }
    }
    private void OnSavedGameWritten(SavedGameRequestStatus status, ISavedGameMetadata metaData)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            Debug.Log("Save successful");
        }
        else
        {
            Debug.LogError("Failed to write saved game data");
        }
    }
    void SaveGameData()
    {

    }
}
