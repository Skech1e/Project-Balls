using System;
using UnityEngine;
public class Rescaler : MonoBehaviour
{
      [Serializable]
      public struct Values
      {
            public float Minimum, Maximum, Value;

            public float GetRange => Maximum - Minimum;
      }
      public Values Old, New;

      public float Rescale() => (((Old.Value - Old.Minimum) * New.GetRange) / Old.GetRange) + New.Minimum;

      private void OnValidate()
      {
            print(Rescale());
      }
}