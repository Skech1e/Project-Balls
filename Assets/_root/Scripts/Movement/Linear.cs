using UnityEngine;

public class Linear : MonoBehaviour
{
    [SerializeField][Range(0.5f, 10f)] float Length, Speed;
    [SerializeField][Range(0,20f)] float offset;
    public bool isHorizontal;
    private Vector3 basketPosition;


    private void Start()
    {
        offset = 12f;
        basketPosition = transform.position;
    }

    private void Update()
    {
        transform.position = basketPosition;

        if(isHorizontal == true)
            basketPosition.x = Mathf.PingPong(Time.time * Speed, Length) + offset;
        else
            basketPosition.y = Mathf.PingPong(Time.time * Speed, Length) + offset;

    }
}
