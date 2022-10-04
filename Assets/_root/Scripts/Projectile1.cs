using GlobalBasket;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    public bool shoot;
    public float force;
    public Vector3 direction;
    public Vector3 defaultPos;
    public GameObject balls;
    Rigidbody rb;
    Trajectory track;

    

    private void Start()
    {
        defaultPos = balls.transform.position;
        rb = balls.GetComponent<Rigidbody>();
        track = FindObjectOfType<Trajectory>();
    }

    private void Update()
    {
        direction.y = track.InputScale.y * Time.fixedDeltaTime;
        direction.z = track.InputScale.y * Time.fixedDeltaTime;
        Shoot();

    }

    PlayerInputs pl;
    void Shoot()
    {
        pl ??= new PlayerInputs();
        pl.Enable();
        pl.Controls.PowerandThrow.performed += context =>
        {
            balls.transform.position = defaultPos;
            rb.velocity = Vector2.zero;
            balls.GetComponent<TrailRenderer>().enabled = true;
            rb.AddForce(direction, ForceMode.Impulse);
            print("k");
        };
        pl.Controls.PowerandThrow.canceled += context =>
        {
            balls.GetComponent<TrailRenderer>().enabled = false;
        };
    }




}
