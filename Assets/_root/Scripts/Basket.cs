using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    protected GameObject Tbasket;

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
    private void DisableBasket()
    {
        gameObject.SetActive(false);
    }


    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
