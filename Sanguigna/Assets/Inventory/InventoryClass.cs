using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
[InitializeOnLoad]
class Item
{
    public int ID;
    public string Name;
    public Sprite Icon;
    public Dictionary<string, int> Items = new Dictionary<string, int>();
    public Item(int iD, string name)
    {
        this.ID = iD;
        this.Name = name;
        this.Icon = Resources.Load<Sprite>(name);
        Items.Add(name, iD);
    }
}