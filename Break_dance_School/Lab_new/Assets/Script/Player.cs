using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Player
	{
		List<Item> Inventory;
		public Player ()
		{
			this.Inventory = new List<Item>();
		}

		public void AddItem(Item oneItem)
		{
			this.Inventory.Add (oneItem);
		}

		public string ShowInventory()
		{
			string temp = "-- Inventory List --\n";

			foreach (Item oneItem in this.Inventory) 
			{
				temp += oneItem.GetName () + "\n";
			}
			return temp;
		}
	}
}

