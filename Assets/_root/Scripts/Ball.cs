using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using Random = Unity.Mathematics.Random;
using GlobalBasket;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    [SerializeField] Vector3 direction;

    public Trajectory track;
    [SerializeField] bool Throw;
    Rigidbody body;
    Vector3 defaultPos;
    private Quaternion defaultRotn;
    Random random;
    [SerializeField] int randomValue;

    PlayerInputs input;
    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        defaultPos = transform.position;
        defaultRotn = transform.rotation;
        random = new Random(seed: 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        body.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = track.InputScale.x * track.precision;
        direction.y = track.InputScale.y * track.precision * 1.5f;
        direction.z = track.InputScale.y * track.precision;        

    }

    private void FixedUpdate()
    {
        ThrowBall();

        if (Throw == true)
            RotateBallOnThrow(randomValue);
        else
            transform.Rotate(69f * Time.deltaTime, 42.0f * Time.deltaTime, 13.37f * Time.deltaTime);

    }

    void ThrowBall()
    {
        input ??= new PlayerInputs();
        input.Enable();
        input.Controls.PowerandThrow.performed += context =>
        {
            if (transform.position == defaultPos)
            {
                body.isKinematic = false;
                body.AddForce(direction, ForceMode.Impulse);
                body.AddTorque(direction , ForceMode.Force);
                Throw = true;
                randomValue = random.NextInt(-1, 2);
                track.gameObject.SetActive(false);
            }
        };
    }

    void ResetBall()
    {
        //transform.rotation = defaultRotn;
        transform.position = defaultPos;
        body.velocity = Vector2.zero;
        body.isKinematic = true;
        track.gameObject.SetActive(true);
    }

    void RotateBallOnThrow(float value)
    {
        //transform.Rotate(value * 240f * Time.fixedDeltaTime, 0, 0);
        //body.AddTorque(value * Time.fixedDeltaTime, 0, 0, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ground" && transform.position != defaultPos)
        {
            Throw = false;
            Invoke(nameof(ResetBall), 2f);
        }
    }
}
