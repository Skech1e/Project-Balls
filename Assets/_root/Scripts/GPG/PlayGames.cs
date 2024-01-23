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

public enum SaveGameOperation
{
    Load, Save
}

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
        //check.text = "entered";
        //check.text = status.ToString();
        if (status == SignInStatus.Success)
        {
            //check.text = "Success";
            
        }
        else
        {
            //check.text = "Failed";

        }
    }

    public void GPGSave(SaveGameOperation operation)
    {
        ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;

        if (operation == SaveGameOperation.Load)
        {
            check.text = "load";
            savedGameClient.OpenWithAutomaticConflictResolution(savepath, DataSource.ReadCacheOrNetwork,
            ConflictResolutionStrategy.UseLongestPlaytime, OnSavedGameOpenedToLoad);

            void OnSavedGameOpenedToLoad(SavedGameRequestStatus status, ISavedGameMetadata metadata)
            {
                savedGameClient.ReadBinaryData(metadata, OnSavedGameDataRead);
            }
        }
        if (operation == SaveGameOperation.Save)
        {
            check.text = "save";
            savedGameClient.OpenWithAutomaticConflictResolution(savepath, DataSource.ReadCacheOrNetwork,
            ConflictResolutionStrategy.UseLongestPlaytime, OnSavedGameOpened);
        }
    }

    private void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata game)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            // handle reading or writing of saved game.
            check.text = "OnSavedGameOpened";

            string scjson = JsonUtility.ToJson(GameManager.saver.scoredata);
            string usrjson = JsonUtility.ToJson(GameManager.saver.usrdata);
            byte[] scdata = Encoding.UTF8.GetBytes(scjson);
            byte[] usrdata = Encoding.UTF8.GetBytes(usrjson);

            SavedGameMetadataUpdate.Builder builder = new SavedGameMetadataUpdate.Builder();
            SavedGameMetadataUpdate update = builder.Build();
            ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
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

    public void OnSavedGameDataRead(SavedGameRequestStatus status, byte[] savedata)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            string data = Encoding.UTF8.GetString(savedata);
            // handle processing the byte array data
            debug.text = data;
            check.text = "Loaded Data from Cloud";
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
}
