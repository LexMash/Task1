using UnityEngine;

public class ItemBox : MonoBehaviour, IPickable
{
    private string _name = "Box";
    public string Name => _name;
}
