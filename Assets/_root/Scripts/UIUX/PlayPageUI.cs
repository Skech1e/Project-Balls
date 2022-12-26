using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPageUI : MonoBehaviour
{
    [SerializeField] List<Transform> ArenaSelector = new();
    [SerializeField] Button Left, Right;
    public int counter;
    PositionTween pt;
    [SerializeField] GameObject LockedPanel;
    
    private Saver saver;
    // Start is called before the first frame update
    void Start()
    {
        saver = GameManager.LevelScoreData as Saver;
    }


    // Update is called once per frame
    void Update()
    {
        if(counter >= ArenaSelector.Count- 1)
            Right.gameObject.SetActive(false); 
        else
            Right.gameObject.SetActive(true);

        if(counter == 0)
            Left.gameObject.SetActive(false);
        else
            Left.gameObject.SetActive(true);

        pt = ArenaSelector[counter].GetComponent<PositionTween>();
    }

    public void OnClickRight()
    {
        counter++;
        ArenaSelector[counter-1].GetComponent<PositionTween>().Disable();
        ArenaSelector[counter].gameObject.SetActive(true);
        if (saver.arenas[counter].unlocked == false)
            LockedPanel.SetActive(true);
    }

    public void OnClickLeft()
    {
        counter--;
        ArenaSelector[counter+1].GetComponent<PositionTween>().Disable();
        ArenaSelector[counter].gameObject.SetActive(true);

        ArenaSelector[counter].localPosition = new Vector2(-Screen.width, 0);
        ArenaSelector[counter].LeanMoveLocalX(0, pt.TimeIn).setEase(pt.EaseTypeIn).setDelay(pt.DelayIn);
    }

    public void ArenaLerping()
    {
        
    }
}
