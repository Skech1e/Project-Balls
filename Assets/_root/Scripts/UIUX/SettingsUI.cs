using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class SettingsUI : MonoBehaviour
{
    [SerializeField] Image spr_music, spr_sound;
    [SerializeField] TextMeshProUGUI txt_graphics, shadow_text;
    [SerializeField] List<Sprite> Toggle = new();
    

    bool Sound, Music;
    enum Graphics : int { Low = 0, Medium = 1, High = 2, Max = 3 };
    private readonly int graphicsLength = Enum.GetValues(typeof(Graphics)).Length;

    [SerializeField]
    private int _counter;
    public int Counter
    {
        get => _counter;
        set
        {
            _counter = Mathf.Clamp(value, 0, graphicsLength);
            _counter = _counter >= graphicsLength ? 0 : _counter;
        }
    }

    //Saving vars
    Saver saver;
    //[SerializeField] ScriptableObject UserConfigData;

    private void Awake()
    {
       saver = GameManager.LevelScoreData as Saver;
    }

    private void OnEnable()
    {
        Sound = saver.LoadUser().Sound;
        Music = saver.LoadUser().Music;
        Counter = saver.LoadUser().Graphics;
        QualitySettings.SetQualityLevel(Counter, false);
    }

    private void OnDisable()
    {
        CloseSave();
    }
    // Start is called before the first frame update
    void Start()
    {        
        spr_sound.sprite = Sound == true ? Toggle[1] : Toggle[0];
        spr_music.sprite = Music == true ? Toggle[1] : Toggle[0];
        txt_graphics.text = shadow_text.text = ((Graphics)Counter).ToString();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleSound()
    {
        Sound = !Sound;
        spr_sound.sprite = Sound == true ? Toggle[1] : Toggle[0];
    }
    public void ToggleMusic()
    {
        Music = !Music;
        spr_music.sprite = Music == true ? Toggle[1] : Toggle[0];
    }
    public void SwitchGraphics()
    {
        Counter++;

        txt_graphics.text = ((Graphics) Counter).ToString();
        shadow_text.text = txt_graphics.text;

        QualitySettings.SetQualityLevel(Counter);
        
    }

    public void CloseSave()
    {
        saver.usrdata.Music = Music;
        saver.usrdata.Sound = Sound;
        saver.usrdata.Graphics = Counter;
        saver.SavetoJson(saver.usrdata);
    }
}
