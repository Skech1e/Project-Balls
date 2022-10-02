using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    [SerializeField] Vector3 direction;

    public Trajectory track;
    [SerializeField] bool Throw;
    Rigidbody body;
    Vector3 defaultPos;
    private Quaternion defaultRotn;


    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        defaultPos = transform.position;
        defaultRotn = transform.rotation;
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
        if (Throw == true && transform.position == defaultPos)
            ThrowBall();

        if (Throw == false)
        {
            transform.rotation = defaultRotn;
            transform.position = defaultPos;
            body.velocity = Vector2.zero;
            body.isKinematic = true;
            track.gameObject.SetActive(true);
        }
    }

    void ThrowBall()
    {
        body.isKinematic = false;
        body.AddForce(direction, ForceMode.Impulse);
        track.gameObject.SetActive(false);
    }

}
