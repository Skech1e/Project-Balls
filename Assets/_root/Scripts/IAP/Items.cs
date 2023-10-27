using UnityEngine;

[CreateAssetMenu(fileName = "ShopItem", menuName = "Shop")]
public class Items : ScriptableObject
{
    public string Name;
    public float Price;
    public object Value;
    public enum ValueType { Numerical, Boolean }
    public ValueType Type;

    public int count;
    public bool boolean_value;
    private void OnValidate()
    {
        if (Type == ValueType.Boolean)
        {
            Value = boolean_value;
            return;
        }
        Value = count;
    }

}
