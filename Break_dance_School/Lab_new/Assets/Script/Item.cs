using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item{
	
	private string name;
	public Item(string input)
	{
		this.name = input;
	}

	public Item()
	{
		this.name = "No Name Given";
	}

	public string GetName()
	{
		return this.name;
	}
}
