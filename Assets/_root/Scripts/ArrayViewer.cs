using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayViewer : MonoBehaviour
{
    public static int X, Y;
    [System.Serializable]
    public class Column
    {
        public bool[] rows = new bool[Y];
    }

    public Column[] columns = new Column[X];

}
