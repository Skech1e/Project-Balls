using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPageUI : MonoBehaviour
{
    [SerializeField] List<Transform> ArenaSelector = new();
    [SerializeField] Button Left, Right;
    [SerializeField] int ArenaCount;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > ArenaCount-1)
            Right.gameObject.SetActive(false);
        else
            Right.gameObject.SetActive(true);

        if(counter == 0)
            Left.gameObject.SetActive(false);
        else
            Left.gameObject.SetActive(true);
    }

    public void OnClickRight()
    {
        counter++;
        ArenaSelector[counter-1].GetComponent<PositionTween>().Disable();
        ArenaSelector[counter].gameObject.SetActive(true);
    }

    public void OnClickLeft()
    {
        counter--;
        ArenaSelector[counter].GetComponent<PositionTween>().Disable();
        ArenaSelector[counter-1].gameObject.SetActive(true);
    }
}
