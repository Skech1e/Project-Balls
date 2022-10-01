using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Test : MonoBehaviour
{
    public Vector3 direction;
    public Vector3 defaultPos;
    public float force;
    public bool shoot, reset;
    Rigidbody rb;

    private void Awake()
    {
        defaultPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        direction.y = force / 2;
        direction.z = force / 2;

        if (shoot == true && transform.position == defaultPos)
        {
            rb.AddForce(direction, ForceMode.Impulse);
        }

        if(reset == true)
        {
            reset = !reset;
            transform.position = defaultPos;
        }
    }
}
