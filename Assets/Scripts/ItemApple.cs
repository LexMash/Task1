using UnityEngine;

public class ItemApple : MonoBehaviour, IPickable
{
    private string _name = "Apple";
    public string Name => _name;
}
