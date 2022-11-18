using UnityEngine;

public class Rotational : MonoBehaviour
{
    [SerializeField][Range(0.5f, 90f)] float Speed;
    [SerializeField][Range(-1.5f, 1.5f)] float OffsetAmount;
    [SerializeField] bool HorizontalOffset;
    [SerializeField] Vector3 Centre;
    Transform basket;

    private void OnValidate()
    {
        Centre = transform.position;
        if(HorizontalOffset == true)
            Centre.x += OffsetAmount;
        else
            Centre.y += OffsetAmount;
    }

    // Start is called before the first frame update
    void Start()
    {
        basket = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        basket.RotateAround(Centre, Vector3.forward, Speed * Time.deltaTime);
        basket.Rotate(0, 0, Speed * Time.deltaTime );
        
    }
}
