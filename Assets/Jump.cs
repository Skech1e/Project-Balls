using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float force;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void JumpFun()
    {
        rb.velocity += new Vector2(0, force);

        //rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
    }
}
