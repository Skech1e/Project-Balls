using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinMenu : MonoBehaviour
{
    [SerializeField] MeshRenderer ball;
    [SerializeField] List<Skin> skins;
    [field: SerializeField] public int skinID { get; private set; }
    [SerializeField] TextMeshProUGUI pricetxt, balance;

    public Button Left, Right, BuyBtn, EquipBtn;

    Saver saver;

    void Start()
    {
        saver = GameManager.saver;

        ball.material = skins[skinID].Material;
        pricetxt.text = skins[skinID].Price.ToString();
        balance.text = saver.usrdata.balance.ToString();

        Left.gameObject.SetActive(skinID != 0);
        Right.gameObject.SetActive(skinID != skins.Count-1);

        if (saver.usrdata.balance < skins[skinID].Price)
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
                skinID = skinID > 0 ? skinID - 1 : skinID;
                ball.material = skins[skinID].Material;
                pricetxt.text = skins[skinID].Price.ToString();
                break;
            case 1:
                skinID = skinID < skins.Count - 1 ? skinID + 1 : skinID;
                ball.material = skins[skinID].Material;
                pricetxt.text = skins[skinID].Price.ToString();
                break;
        }

        if (skinID == skins.Count - 1)
            Right.gameObject.SetActive(false);
        else
            Right.gameObject.SetActive(true);

        if (skinID == 0)
            Left.gameObject.SetActive(false);
        else
            Left.gameObject.SetActive(true);

        if (saver.usrdata.balance < skins[skinID].Price)
            BuyBtn.interactable = false;
        else
            BuyBtn.interactable = true;

        ReflectSavedData();
    }

    public void Buy()
    {
        saver.usrdata.balance -= skins[skinID].Price;
        saver.inventory.skinId.Add(skinID);
        saver.SavetoJson(saver.inventory);
        balance.text = saver.usrdata.balance.ToString();
        ReflectSavedData();
    }

    public void Equip()
    {
        saver.usrdata.active_skin = skins[skinID].Material;
        EquipBtn.interactable = false;
    }

    void ReflectSavedData()
    {
        if (saver.inventory.skinId.Contains(skinID))
        {
            BuyBtn.gameObject.SetActive(false);
            EquipBtn.gameObject.SetActive(true);
            pricetxt.text = "sold";
            if(saver.usrdata.active_skin == skins[skinID].Material)
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
}
