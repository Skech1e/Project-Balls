using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueRender : MonoBehaviour
{
    [SerializeField] Camera blurCam;
    [SerializeField] Material blurMat;

    void Start()
    {
        if (blurCam.targetTexture != null)
            blurCam.targetTexture.Release();
        blurCam.targetTexture = new RenderTexture(Screen.width, Screen.height, 24, RenderTextureFormat.ARGB32, 1);
        blurMat.SetTexture("_RenTex", blurCam.targetTexture);
    }
}
