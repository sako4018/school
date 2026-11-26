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
            return; // 
        }
        items.Add(new InventoryItem(name, quantity)); 
    }

    public void RemoveItem(string name)
    {
        // 
        for (int i = items.Count - 1; i >= 0; i--)
        {
            if (items[i].Name == name)
            {
                items.RemoveAt(i); //
            }
        }
    }

    public void DisplayItems()
    {
        Console.WriteLine("Inventory:");
        for (int i = 0; i < items.Count; i++) // FIX: <= went out of range, must be <
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
