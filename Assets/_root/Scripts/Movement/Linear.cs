using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Linear : Motion
{
    public float Length;
    public enum Direction { Left, Right, Upwards, Downwards}

    [SerializeField]
    private Direction direction;


    protected override void Move(float value)
    {
        Mathf.PingPong(Time.time, value);
    }
    private void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time*Speed, Length)+12, transform.position.y, transform.position.z);
    }
}
