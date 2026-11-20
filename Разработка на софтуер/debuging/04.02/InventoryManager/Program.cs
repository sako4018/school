using System;
using System.Collections.Generic;

class InventoryItem
{
    public string Name;
    public int Quantity;

    public InventoryItem(string name, int qty)
    {
        Name = name;
        Quantity = qty;
    }
}

class InventoryManager
{
    private List<InventoryItem> items = new List<InventoryItem>();

    public void AddItem(string name, int quantity)
    {
        if (quantity < 0)
        {
            Console.WriteLine("Quantity cannot be negative");
        }
        items.Add(new InventoryItem(name, quantity));
    }

    public void RemoveItem(string name)
    {
        foreach (var item in items)
        {
            if (item.Name == name)
            {
                items.Remove(item);
            }
        }
    }

    public void DisplayItems()
    {
        Console.WriteLine("Inventory:");
        for (int i = 0; i <= items.Count; i++)
        {
            Console.WriteLine(items[i].Name + " - " + items[i].Quantity);
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManager inventory = new InventoryManager();
        inventory.AddItem("Apples", -5);
        inventory.AddItem("Bananas", 10);
        inventory.RemoveItem("Pears");
        inventory.DisplayItems();
    }
}
