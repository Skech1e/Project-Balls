using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public static ShopManager instance {  get; private set; }

    [SerializeField]
    private Items[] items;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);

        items = new Items[6];
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
