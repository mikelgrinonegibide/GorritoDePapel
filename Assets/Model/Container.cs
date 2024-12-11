using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Container
{
    [SerializeField] public List<Item> Items;

    public Container()
    {
        this.Items = new List<Item>();
    }

}
