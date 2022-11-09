using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[ExecuteInEditMode]
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
                if (gameObject.GetComponent<Linear>() == null)
                    gameObject.AddComponent<Linear>().isHorizontal = true;
                return;

            case Direction.Vertical:
                if (gameObject.GetComponent<Linear>() == null)
                    gameObject.AddComponent<Linear>().isHorizontal = false;
                return;

            case Direction.Rotational:
                if (gameObject.GetComponent<Rotational>() == null)
                    gameObject.AddComponent<Rotational>();
                return;
        }

        //switch (MoveDirection)
        //{
        //    case Direction.Still:

        //        break;

        //    case Direction.Horizontal:
        //        if (linear == null)
        //            this.AddComponent<Linear>();
        //        linear = GetComponent<Linear>();
        //        linear.isHorizontal = true;
        //        break;

        //    case Direction.Vertical:
        //        if (linear == null)
        //            this.AddComponent<Linear>();
        //        linear = GetComponent<Linear>();
        //        linear.isHorizontal = false;
        //        break;

        //    case Direction.Rotational:
        //        if (rotational == null)
        //        {
        //            this.AddComponent<Rotational>();
        //            if (linear != null)

        //                DestroyImmediate(linear);
        //        }
        //        rotational = GetComponent<Rotational>();
        //        break;

        //    default:
        //        break;
        //}


    }

    private void Clear()
    {
        var mp = GetComponents<MotionParams>();

        foreach (MotionParams found in mp)
        {
            DestroyImmediate(found);
        }
    }
}
