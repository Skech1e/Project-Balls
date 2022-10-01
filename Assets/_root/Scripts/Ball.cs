using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Ball : MonoBehaviour
{
    LineRenderer trajectory;

    [SerializeField] Vector3 currentPosition, targetPosition, direction;
    [SerializeField] float forceMultiplier, minForce, maxForce, throwForce;
    [SerializeField] float Angle, ballheight, trajectoryPoint, flightTime, mass, interval;

    [SerializeField] int maxSteps;

    Vector2 tracjectoryPath;

    [SerializeField] List<Vector2> points = new();

    [Header("Debug")]
    [SerializeField]
    private bool _debugAlwaysDrawTrajectory = false;

    RaycastHit hit;

    public Trajectory track;
    [SerializeField] bool Throw;
    Rigidbody body;
    Vector3 defaultPos;
    private Quaternion defaultRotn;


    private void Awake()
    {
        currentPosition = transform.position;
        ballheight = currentPosition.y;
        trajectory = GetComponent<LineRenderer>();
        trajectory.positionCount = 20;
        body = GetComponent<Rigidbody>();
        defaultPos = transform.position;
        defaultRotn = transform.rotation;
    }

    // Start is called before the first frame update
    void Start()
    {
        maxSteps = (int)(flightTime / interval);
    }

    // Update is called once per frame
    void Update()
    {
        throwForce = throwForce / mass * Time.fixedDeltaTime;
        currentPosition = transform.position;
        //DrawTrajectory();
        //Test();
        direction.x = track.InputScale.x * Time.fixedDeltaTime;
        direction.y = track.InputScale.y * Time.fixedDeltaTime;
        direction.z = track.InputScale.y * Time.fixedDeltaTime;
    }

    private void FixedUpdate()
    {
        if (Throw == true && transform.position == defaultPos)
            UpdatePos();

        if (Throw == false)
        {
            transform.rotation = defaultRotn;
            transform.position = defaultPos;
            body.velocity = Vector2.zero;
        }
    }

    void UpdatePos()
    {
        body.AddForce(direction, ForceMode.Impulse);
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
        for (int i = 0; i < maxSteps; i++)
        {
            tracjectoryPath = currentPosition + transform.up + i * interval * throwForce * transform.up;
            tracjectoryPath.y += Physics.gravity.y / 2 * Mathf.Pow(i * interval, 2);
            points.Add(tracjectoryPath);

            trajectory.SetPosition(i, points[i]);
        }
    }
}
