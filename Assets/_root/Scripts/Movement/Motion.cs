using UnityEngine;
public class Motion : MonoBehaviour
{
    enum Direction { Still, Horizontal, Vertical, Rotational }

    [SerializeField]
    Direction direction;


    private void OnValidate()
    {
        switch (direction)
        {
            case Direction.Still: return;

            case Direction.Horizontal:
                gameObject.GetComponent<Linear>().enabled = !gameObject.GetComponent<Rotational>().enabled;
                gameObject.GetComponent<Linear>().isHorizontal = true;
                return;

            case Direction.Vertical:
                gameObject.GetComponent<Linear>().enabled = !gameObject.GetComponent<Rotational>().enabled;
                gameObject.GetComponent<Linear>().isHorizontal = false;
                return;

            case Direction.Rotational:
                gameObject.GetComponent<Rotational>().enabled = !gameObject.GetComponent<Linear>().enabled;
                return;
        }

    }

}
