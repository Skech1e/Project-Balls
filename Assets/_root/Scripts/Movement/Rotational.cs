using UnityEngine;

public class Rotational : MonoBehaviour
{
    [SerializeField][Range(0.5f, 90f)] float Angle, Speed;
    [SerializeField][Range(0.1f, 1.5f)] float OffsetAmount;
    [SerializeField] bool HorizontalOffset;
    [SerializeField] Vector3 Centre;
    Transform basketParent;

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
        basketParent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        basketParent.transform.RotateAround(Centre, Vector3.forward, Angle * Time.deltaTime);
        transform.Rotate(0, 0, Angle * Time.deltaTime );
        
    }
}
