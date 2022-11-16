using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [SerializeField] Image music, sound;
    [SerializeField] TextMeshProUGUI txt_graphics;
    [SerializeField] Sprite on, off;
    [SerializeField] List<Sprite> spr_graphics = new();
    enum Graphics { Low, Medium, High };
    [SerializeField] Graphics graphics = new Graphics();

    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleSound()
    {

    }
    public void ToggleMusic()
    {

    }
    public void SwitchGraphics()
    {
        counter++;
        graphics = (Graphics)counter;
        txt_graphics.text = graphics.ToString();
        txt_graphics.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = txt_graphics.text;

        if (counter > 2)
            counter = 0;
    }
}
