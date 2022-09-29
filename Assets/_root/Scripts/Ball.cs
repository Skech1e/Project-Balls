using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Ball : MonoBehaviour
{
    LineRenderer trajectory;

    [SerializeField] Vector3 currentPosition, targetPosition;
    [SerializeField] float forceMultiplier, minForce, maxForce, throwForce;
    [SerializeField] float Angle, ballheight, trajectoryPoint, flightTime, mass, interval;

    [SerializeField] int maxSteps;

    Vector2 tracjectoryPath;

    [SerializeField] List<Vector2> points = new();

    [Header("Debug")]
    [SerializeField]
    private bool _debugAlwaysDrawTrajectory = false;

    RaycastHit hit;
    
    private void Awake()
    {
        currentPosition = transform.position;
        ballheight = currentPosition.y;
        trajectory = GetComponent<LineRenderer>();
        trajectory.positionCount = 20;
    }

    // Start is called before the first frame update
    void Start()
    {
        maxSteps = (int)(flightTime/interval);        
    }

    // Update is called once per frame
    void Update()
    {
        throwForce = throwForce/mass * Time.fixedDeltaTime;
        currentPosition = transform.position;
        //DrawTrajectory();
        //Test();
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

    void Test()
    {
        for(int i = 0; i < maxSteps; i++)
        {
            tracjectoryPath = currentPosition + transform.up + i * interval * throwForce * transform.up;
            tracjectoryPath.y += Physics.gravity.y / 2 * Mathf.Pow(i * interval, 2);
            points.Add(tracjectoryPath);

            trajectory.SetPosition(i, points[i]);
        }
    }
}
