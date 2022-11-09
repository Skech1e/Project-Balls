using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Linear;
using static UnityEngine.Rendering.DebugUI;

public class Linear : MonoBehaviour
{
    [Min(0.5f)] public float Length, Speed, offset;
    public float X;
    public bool isHorizontal;
    private Vector3 basketPosition;


    private void Start()
    {
        offset = 12f;
        basketPosition = transform.position;
    }

    private void Update()
    {
        //basketPosition = transform.position;
        transform.position = basketPosition;

        if(isHorizontal == true)
            basketPosition.x = Mathf.PingPong(Time.time * Speed, Length) + offset;
        else
            basketPosition.y = Mathf.PingPong(Time.time * Speed, Length) + offset;

    }
}
