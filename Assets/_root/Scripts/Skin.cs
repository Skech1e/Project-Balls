using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "BallSkin", menuName = "Ball Skin")]
[System.Serializable]
public class Skin : ScriptableObject
{
    [field: SerializeField]
    public byte id { get; private set; }
    [field: SerializeField]
    public string Name { get; private set; }
    [field: SerializeField]
    public Material Material { get; private set; }
    [field: SerializeField]
    public int Price { get; private set; }

    public Sprite icon;
    Texture iconTexture;

    //string assetPath = AssetDatabase.GetAssetPath()

    private void OnValidate()
    {
        
    }
}
