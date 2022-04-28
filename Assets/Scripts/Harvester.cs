using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvester : MonoBehaviour
{
    private List<string> _items;

    public string[] ItemList
    {
        get { return _items.ToArray(); }
    }

    public delegate void ItemAdded(Vector2 position);
    public event ItemAdded OnItemAdded;

    private void Start()
    {
        _items = new List<string>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<IPickable>(out IPickable pickable))
        {
            _items.Add(pickable.Name);

            OnItemAdded?.Invoke(new Vector2(collision.transform.position.x, 
                collision.transform.position.y));

            print($"Pick {pickable.Name}");
            print($"Count of {pickable.Name} - {ItemsCount(pickable.Name)}");

            Destroy(collision.gameObject);
        }
    }

    private int ItemsCount(string name)
    {
        int count = 0;

        foreach (string item in _items)
        {
            if (name == item) count++;
        }

        return count;
    }
}
