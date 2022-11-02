using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Motion : MonoBehaviour
{
    public float Speed;

    protected abstract void Move(float value);
}
