using UnityEngine;

public class Linear : MonoBehaviour
{
    [SerializeField][Range(0.1f, 10f)] float Length, Speed;
    [SerializeField][Range(0, 20f)] float offset;
    enum Axis { Horizontal, Vertical, Diagonal, Diagonal_Inverse }
    [SerializeField] Axis axis;
    enum MovementDirection { positive = 1, negative = -1 }
    [SerializeField] MovementDirection moveDirection;

    private Vector3 basketPosition;
    private float moveValue;
    private int direction;


    private void Start()
    {
        //offset = 12f;
        basketPosition = transform.GetChild(1).localPosition;
    }

    private void Update()
    {
        transform.GetChild(1).localPosition = basketPosition;
        moveValue = Mathf.PingPong(Time.time * Speed, Length) + offset;

        if (axis == Axis.Horizontal)
            basketPosition.x = moveValue * (int)moveDirection;
        else if (axis == Axis.Diagonal)
        {
            basketPosition.x = moveValue * (int)moveDirection;
            basketPosition.y = moveValue * (int)moveDirection;
        }
        else if(axis == Axis.Diagonal_Inverse)
        {
            basketPosition.x = (moveValue/2) * (int)moveDirection;
            basketPosition.y = -(moveValue / 2) * (int)moveDirection;
        }
        else
            basketPosition.y = moveValue * (int)moveDirection;

    }
}

