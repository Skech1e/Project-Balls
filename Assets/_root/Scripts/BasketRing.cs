using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketRing : MonoBehaviour
{
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        source.Play();
    }
}
