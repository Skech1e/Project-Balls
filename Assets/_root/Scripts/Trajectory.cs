using GlobalBasket;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(LineRenderer))]
public class Trajectory : MonoBehaviour
{
    [SerializeField] LineRenderer line;
    [SerializeField][Range(20, 100)] int lineSegment;
    [SerializeField] Vector3 velocity;
    [SerializeField] float Yveloc;
    [SerializeField] float gravity;
    [SerializeField] float Ymax;

    [Header("Linecast")]
    [SerializeField] int linecastSegment;
    [SerializeField] LayerMask hitMask;

    [SerializeField] PlayerInputs input;

    [SerializeField] Vector2 InputScale;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
        gravity = Mathf.Abs(Physics.gravity.y);
        line.useWorldSpace = false;
        input = new PlayerInputs();
        velocity.z = 10f;
        velocity.y = 10f;

    }
    void Start()
    {

    }

    private void OnEnable()
    {
        input.Enable();
        input.Controls.Aim.started += TouchAim;
        input.Controls.Aim.performed += TouchAim;
        input.Controls.Aim.canceled += TouchAim;
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
            InputScale.y += context.ReadValue<Vector2>().x;
        }
        else if(action == InputActionPhase.Canceled)
        {
            InputScale.y = 0;
        }
    }

    void Update()
    {
        Yveloc = velocity.y;
        transform.rotation = Quaternion.Euler(InputScale);
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

                RaycastHit hitPoint;
                var hit = Physics.Linecast(CalculateLinePoints(t), CalculateLinePoints(tt), out hitPoint, hitMask);

                if (hit)
                    return hitPoint.point;
            }
            return CalculateLinePoints(MaxYDuration());
        }
    }
    private Vector3 CalculateLinePoints(float t)
    {
        float z = velocity.z * t;
        float y = (velocity.y * t) - (gravity * Mathf.Pow(t, 2) / 2);
        return new Vector3(0, y, z);
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
