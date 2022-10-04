using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    [SerializeField] Transform Final;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Final.gameObject.SetActive(true);
            Invoke(nameof(Reset), 2f);
        }
    }

    private void Awake()
    {
        Final.gameObject.SetActive(false);
    }

    private void Reset()
    {
        Final.gameObject.SetActive(false);
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
