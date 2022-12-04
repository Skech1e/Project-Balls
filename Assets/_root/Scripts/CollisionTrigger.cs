using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    [SerializeField] BoxCollider FinalCollider;
    public void OnTriggerEnter(Collider other)
    {
        print("second");
        if(other.gameObject.tag == "Player")
        {
            FinalCollider.enabled = true;
        }
    }


    private void Awake()
    {
        
    }

    private void Reset()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        FinalCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
