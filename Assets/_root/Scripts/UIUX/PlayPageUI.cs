using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayPageUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI starBalance, starBalanceHUD, coinBalanceHUD, starPrice, coin_price;
    [SerializeField] List<Transform> ArenaSelector = new();
    [SerializeField] Button Left, Right, UnlockBtn, BuyBtn;
    public int counter;
    PositionTween pt;
    [SerializeField] GameObject LockedPanel;

    [SerializeField] List<GameObject> arenaPics = new();

    private Saver saver;

    public delegate void UpdateArena();
    public static event UpdateArena updateIcons;

    private void OnEnable()
    {
        starBalance.text = saver.usrdata.starbalance.ToString();
        starBalanceHUD.text = saver.usrdata.starbalance.ToString();
        coinBalanceHUD.text = saver.usrdata.balance.ToString();
    }

    private void OnDisable()
    {
        ResetLevelSelection();
    }

    void Start()
    {
        saver = GameManager.saver;
        starBalance.text = saver.usrdata.starbalance.ToString();
        starBalanceHUD.text = saver.usrdata.starbalance.ToString();
        coinBalanceHUD.text = saver.usrdata.balance.ToString();
    }


    void Update()
    {
        if (counter >= ArenaSelector.Count - 1)
            Right.gameObject.SetActive(false);
        else
            Right.gameObject.SetActive(true);

        if (counter == 0)
            Left.gameObject.SetActive(false);
        else
            Left.gameObject.SetActive(true);

        pt = ArenaSelector[counter].GetComponent<PositionTween>();
    }

    public void OnClickRight()
    {
        counter++;
        ArenaSelector[counter - 1].GetComponent<PositionTween>().Disable();
        arenaPics[counter - 1].SetActive(false);

        ArenaSelector[counter].gameObject.SetActive(true);
        arenaPics[counter].SetActive(true);
        UpdateDetails();
    }

    public void OnClickLeft()
    {
        counter--;
        ArenaSelector[counter + 1].GetComponent<PositionTween>().Disable();
        arenaPics[counter + 1].SetActive(false);
        ArenaSelector[counter].gameObject.SetActive(true);
        arenaPics[counter].SetActive(true);
        UpdateDetails();

        ArenaSelector[counter].localPosition = new Vector2(-Screen.width, 0);
        ArenaSelector[counter].LeanMoveLocalX(0, pt.TimeIn).setEase(pt.EaseTypeIn).setDelay(pt.DelayIn);
    }

    void ResetLevelSelection()
    {
        ArenaSelector[counter].gameObject.SetActive(false);
        arenaPics[counter].SetActive(false);
        counter = 0;
        arenaPics[counter].SetActive(true);
        ArenaSelector[counter].gameObject.SetActive(true);
    }

    void UpdateDetails()
    {
        //starBalance.text = saver.usrdata.starbalance.ToString();
        if (saver.arenas[counter].unlocked == false)
        {
            LockedPanel.SetActive(true);
            starPrice.text = saver.arenas[counter].starPrice.ToString();
            coin_price.text = saver.arenas[counter].coinPrice.ToString();
            if (saver.arenas[counter - 1].unlocked != true)
            {
                UnlockBtn.interactable = false;
                BuyBtn.interactable = false;
            }
            else
            {
                print(saver.usrdata.starbalance);
                if (saver.usrdata.starbalance > saver.arenas[counter].starPrice)
                    UnlockBtn.interactable = true;
                if (saver.usrdata.balance > saver.arenas[counter].coinPrice)
                    BuyBtn.interactable = true;
            }
        }
    }

    public void UnlockArena(int mode)
    {
        switch (mode)
        {
            case 0:
                saver.usrdata.starbalance -= saver.arenas[counter].starPrice;
                starBalanceHUD.text = saver.usrdata.starbalance.ToString();
                break;
            case 1:
                saver.usrdata.balance -= saver.arenas[counter].coinPrice;
                coinBalanceHUD.text = saver.usrdata.balance.ToString();
                break;
        }
        saver.arenas[counter].unlocked = true;
        saver.arenas[counter].levels[0].Unlocked = true;
        updateIcons.Invoke();
        UnlockBtn.interactable = false;
        BuyBtn.interactable = false;
        LockedPanel.SetActive(false);
    }
}
