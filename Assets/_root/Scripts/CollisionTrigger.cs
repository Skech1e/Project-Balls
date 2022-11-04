using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    [SerializeField] BoxCollider FinalCollider;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            FinalCollider.enabled = true;
        }
    }


    private void Awake()
    {
        FinalCollider.enabled = false;
    }

    private void Reset()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
