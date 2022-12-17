using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using Unity.VisualScripting;

[InitializeOnLoad]
class AddItems
{
    static AddItems()
    {
        Item negr = new Item(0, "niger");
        Item black = new Item(1, "black gay");
        foreach (var item in black.Items)
        {
            Debug.Log(item);
        }

    }
}