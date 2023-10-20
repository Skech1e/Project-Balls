using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinMenu : MonoBehaviour
{
    [SerializeField] MeshRenderer ball;
    [SerializeField] List<Skin> skinList;
    [field: SerializeField] public int srno { get; private set; }
    [SerializeField] TextMeshProUGUI pricetxt, balance;

    public Button Left, Right, BuyBtn, EquipBtn;

    Saver saver;

    private void OnEnable()
    {
        saver = GameManager.saver;
        SortPurchasedSkins();
    }

    void Start()
    {  
        ball.material = skinList[srno].Material;
        pricetxt.text = skinList[srno].Price.ToString();
        balance.text = saver.usrdata.inventory.balance.ToString();

        Left.gameObject.SetActive(srno != 0);
        Right.gameObject.SetActive(srno != skinList.Count-1);

        if (saver.usrdata.inventory.balance < skinList[srno].Price)
            BuyBtn.interactable = false;
        else
            BuyBtn.interactable = true;

        ReflectSavedData();
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        ball.transform.Rotate(140 * Time.deltaTime * Vector3.back);
        ball.transform.parent.Rotate(60 * Time.deltaTime * Vector3.right, Space.Self);
    }

    public void SkinSelection(int order)
    {
        switch (order)
        {
            case -1:
                srno = (byte)(srno > 0 ? srno - 1 : srno);
                ball.material = skinList[srno].Material;
                pricetxt.text = skinList[srno].Price.ToString();
                break;
            case 1:
                srno = (byte)(srno < skinList.Count - 1 ? srno + 1 : srno);
                ball.material = skinList[srno].Material;
                pricetxt.text = skinList[srno].Price.ToString();
                break;
        }

        if (srno == skinList.Count - 1)
            Right.gameObject.SetActive(false);
        else
            Right.gameObject.SetActive(true);

        if (srno == 0)
            Left.gameObject.SetActive(false);
        else
            Left.gameObject.SetActive(true);

        if (saver.usrdata.inventory.balance < skinList[srno].Price)
            BuyBtn.interactable = false;
        else
            BuyBtn.interactable = true;

        ReflectSavedData();
    }

    public void Buy()
    {
        saver.usrdata.inventory.balance -= skinList[srno].Price;
        saver.usrdata.inventory.skinList.Add(skinList[srno].id);
        saver.SavetoJson(saver.usrdata);
        skinList.Insert(1, skinList[srno]);
        skinList.RemoveAt(srno+1);
        srno = 1;
        ReflectSavedData();
        balance.text = saver.usrdata.inventory.balance.ToString();
    }

    public void Equip()
    {
        saver.usrdata.inventory.active_skin = skinList[srno].id;
        EquipBtn.interactable = false;
    }

    void ReflectSavedData()
    {
        if (saver.usrdata.inventory.skinList.Contains(skinList[srno].id))
        {
            BuyBtn.gameObject.SetActive(false);
            EquipBtn.gameObject.SetActive(true);
            pricetxt.text = "owned";
            if(saver.usrdata.inventory.active_skin == skinList[srno].id)
                EquipBtn.interactable = false;
            else
                EquipBtn.interactable = true;
        }
        else
        {
            BuyBtn.gameObject.SetActive(true);
            EquipBtn.gameObject.SetActive(false);
        }
    }

    void SortPurchasedSkins()
    {
        var list = saver.usrdata.inventory.skinList;
        for (byte i = 0; i < list.Count; i++)
        {
            skinList.Insert(i, skinList[list[i]]);
            skinList.RemoveAt(list[i] + 1);
        }
    }
}
