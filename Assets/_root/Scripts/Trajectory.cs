using GlobalBasket;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(LineRenderer))]
public class Trajectory : MonoBehaviour
{
    [SerializeField] LineRenderer line;
    [SerializeField][Range(20, 100)] int lineSegment;
    public Vector3 velocity;
    [SerializeField] float Yveloc;
    [SerializeField] float gravity;
    [SerializeField] float Ymax;

    [Header("Linecast")]
    [SerializeField] int linecastSegment;
    [SerializeField] LayerMask hitMask;
    public Vector2 InputScale;
    [SerializeField] PlayerInputs input;
    

    Vector3[] lineArray;
    public Vector3[] ballPath;
    Ball ball;
    public Vector3 trajectoryDefaultPos;

    [Space]
    public float clampX0, clampX1, clampY0, clampY1;
    [Range(0.001f, 0.1f)] public float precision;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
        gravity = Mathf.Abs(Physics.gravity.y);
        input = new PlayerInputs();
        velocity.z = 10f;
        velocity.y = 10f;
        ball = FindObjectOfType<Ball>();
    }
    void Start()
    {
        transform.position = ball.transform.position;
        precision = 0.0069f;
    }

    private void OnEnable()
    {
        input.Enable();
        input.Controls.Aim.started += TouchAim;
        input.Controls.Aim.performed += TouchAim;
        input.Controls.Aim.canceled += TouchAim;
        InputScale = Vector3.zero;
    }

    private void OnDisable()
    {
        input.Disable();
        input.Controls.Aim.started -= TouchAim;
        input.Controls.Aim.performed -= TouchAim;
        input.Controls.Aim.canceled -= TouchAim;
    }

    void TouchAim(InputAction.CallbackContext context)
    {
        var action = context.phase;

        if(action == InputActionPhase.Performed)
        {            
            InputScale += context.ReadValue<Vector2>();
        }
        else if(action == InputActionPhase.Canceled)
        {
            //InputScale.x = 0;
        }
    }

    void Update()
    {
        ClampInputValues();
        velocity.x = InputScale.x * precision;
        velocity.y = InputScale.y * precision * 1.4f;
        velocity.z = InputScale.y * precision;
        Yveloc = velocity.y;
        RenderLine();
        ballPath = lineArray;
    }

    void ClampInputValues()
    {
        InputScale.x = Mathf.Clamp(InputScale.x, clampX0/precision, clampX1 / precision);
        InputScale.y = Mathf.Clamp(InputScale.y, clampY0/precision, clampY1 / precision);
    }

    void RenderLine()
    {
        line.positionCount = lineSegment + 1;
        line.SetPositions(CalculateLineArray());
        //yield return null;
    }

    private Vector3[] CalculateLineArray()
    {
        lineArray = new Vector3[lineSegment + 1];

        var lowestTimevalue = MaxZDuration() / lineSegment;

        for (int i = 0; i < lineArray.Length; i++)
        {
            var t = lowestTimevalue * i;
            lineArray[i] = CalculateLinePoints(t);
        }
        return lineArray;
    }

    Vector3 HitDetection
    {
        get
        {
            var lowestTimeValue = MaxYDuration() / linecastSegment;

            for (int i = 0; i < linecastSegment + 1; i++)
            {
                var t = lowestTimeValue * i;
                var tt = lowestTimeValue * (i + 1);
                var hit = Physics.Linecast(CalculateLinePoints(t), CalculateLinePoints(tt), out RaycastHit hitPoint, hitMask);

                if (hit)
                {
                    return hitPoint.point;
                }
            }
            return CalculateLinePoints(MaxYDuration());
        }
    }
    private Vector3 CalculateLinePoints(float t)
    {
        float x = transform.position.x+velocity.x * t;
        float z = transform.position.z+velocity.z * t;
        float y = (transform.position.y + velocity.y * t) - (gravity * Mathf.Pow(t, 2) / 2);
        return new Vector3(x, y, z);
    }

    float MaxYDuration()
    {
        var t = (Yveloc + Mathf.Sqrt(Yveloc * Yveloc + 2 * gravity * (transform.position.y - Ymax))) / 2;
        return t;
    }

    float MaxZDuration()
    {
        var z = velocity.z;
        if(z == 0)
        {
            velocity.z = 000.1f;
            z = velocity.z;
        }
        var t = (HitDetection.z - transform.position.z) / z;
        return t;
    }

    

}
