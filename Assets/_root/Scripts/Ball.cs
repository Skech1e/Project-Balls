using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Ball : MonoBehaviour
{
    LineRenderer trajectory;

    [SerializeField] Vector3 currentPosition, targetPosition;
    [SerializeField] float forceMultiplier, minForce, maxForce;
    [SerializeField] float Angle, ballheight, trajectoryPoint;

    [Header("Debug")]
    [SerializeField]
    private bool _debugAlwaysDrawTrajectory = false;

    RaycastHit hit;
    
    private void Awake()
    {
        currentPosition = transform.position;
        ballheight = currentPosition.y;
        trajectory = GetComponent<LineRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DrawTrajectory();
    }

    void DrawTrajectory()
    {
        Ray ray = new(currentPosition, Vector3.forward * minForce);

        var curvePoints = new List<Vector3>
        {
            currentPosition
        };

        while (!Physics.Raycast(ray, out hit, maxForce))
        {
            _ = targetPosition / minForce;
        }

        if (hit.transform)
        {
            curvePoints.Add(hit.point);
        }

        trajectory.positionCount = curvePoints.Count;
        trajectory.SetPositions(curvePoints.ToArray());
    }
}
