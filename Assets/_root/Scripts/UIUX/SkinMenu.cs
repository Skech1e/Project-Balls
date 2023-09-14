using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinMenu : MonoBehaviour
{
    [SerializeField] MeshRenderer ball;
    [SerializeField] List<Skin> skins;
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
        ball.material = skins[srno].Material;
        pricetxt.text = skins[srno].Price.ToString();
        balance.text = saver.usrdata.balance.ToString();

        Left.gameObject.SetActive(srno != 0);
        Right.gameObject.SetActive(srno != skins.Count-1);

        if (saver.usrdata.balance < skins[srno].Price)
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
                ball.material = skins[srno].Material;
                pricetxt.text = skins[srno].Price.ToString();
                break;
            case 1:
                srno = (byte)(srno < skins.Count - 1 ? srno + 1 : srno);
                ball.material = skins[srno].Material;
                pricetxt.text = skins[srno].Price.ToString();
                break;
        }

        if (srno == skins.Count - 1)
            Right.gameObject.SetActive(false);
        else
            Right.gameObject.SetActive(true);

        if (srno == 0)
            Left.gameObject.SetActive(false);
        else
            Left.gameObject.SetActive(true);

        if (saver.usrdata.balance < skins[srno].Price)
            BuyBtn.interactable = false;
        else
            BuyBtn.interactable = true;

        ReflectSavedData();
    }

    public void Buy()
    {
        saver.usrdata.balance -= skins[srno].Price;
        saver.inventory.skinId.Add(skins[srno].id);
        saver.SavetoJson(saver.inventory);
        skins.Insert(1, skins[srno]);
        skins.RemoveAt(srno+1);
        srno = 1;
        ReflectSavedData();
        balance.text = saver.usrdata.balance.ToString();
    }

    public void Equip()
    {
        saver.usrdata.active_skin = skins[srno].Material;
        EquipBtn.interactable = false;
    }

    void ReflectSavedData()
    {
        if (saver.inventory.skinId.Contains(skins[srno].id))
        {
            BuyBtn.gameObject.SetActive(false);
            EquipBtn.gameObject.SetActive(true);
            pricetxt.text = "owned";
            if(saver.usrdata.active_skin == skins[srno].Material)
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
        var skinList = saver.inventory.skinId;
        for (int i = 0; i < skinList.Count; i++)
        {
            skins.Insert(i, skins[skinList[i]]);
            skins.RemoveAt(skinList[i] + 1);
        }
    }
}
