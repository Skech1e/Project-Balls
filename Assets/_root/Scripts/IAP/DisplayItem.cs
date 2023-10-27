using TMPro;
using UnityEngine;

public class DisplayItem : MonoBehaviour
{
    [SerializeField]
    private Items item;
    [SerializeField]
    private TextMeshProUGUI Name;
    [SerializeField]
    private TextMeshProUGUI Price, PriceShadow;

    private void OnValidate()
    {
        Name.text = item.count > 10000 ? item.name : item.count.ToString();
        Price.text = PriceShadow.text = item.Price.ToString();
    }

    private void Awake()
    {
        Name.text = item.count > 10000 ? item.name : item.count.ToString();
        Price.text = PriceShadow.text = item.Price.ToString();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
