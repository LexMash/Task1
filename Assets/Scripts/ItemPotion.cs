using UnityEngine;

public class ItemPotion : MonoBehaviour, IPickable
{
    private string _name = "Potion";

    public string Name => _name;

}
