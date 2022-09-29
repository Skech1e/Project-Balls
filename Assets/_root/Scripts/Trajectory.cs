using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajectory : MonoBehaviour
{
    [SerializeField] LineRenderer line;
    [SerializeField] int lineSegment;
    [SerializeField] Vector3 velocity;
    [SerializeField] float gravity;


    private void Awake()
    {
        line = GetComponent<LineRenderer>();
        lineSegment = 20;
        gravity = Mathf.Abs(Physics.gravity.y);
    }
    void Start()
    {
        
    }


    void Update()
    {
        StartCoroutine(RenderLine());
    }

    IEnumerator RenderLine()
    {
        line.positionCount = lineSegment + 1;
        line.SetPositions(CalculateLineArray());
        yield return null;
    }

    private Vector3[] CalculateLineArray()
    {
        Vector3[] lineArray = new Vector3[lineSegment + 1];

        for(int i = 0; i < lineSegment; i++)
        {
            var t = i / (float)lineArray.Length;
            lineArray[i] = CalculateLinePoints(t);
        }
        return lineArray;
    }

    private Vector3 CalculateLinePoints(float t)
    {
        float x = velocity.x * t;
        float y = (velocity.y * t) - (gravity * Mathf.Pow(t, 2) / 2);
        return new Vector3(x + transform.position.x, y + transform.position.y, 0);
    }
}
