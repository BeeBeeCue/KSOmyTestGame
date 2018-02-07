using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AssemblyCSharp;

public class GameController : MonoBehaviour {
	Player pl;
	private Dictionary<Button, Item> buttonMap = new Dictionary<Button, Item> ();
	private Text textInventory;
	private Button grayButton;
	private Button pinkButton;
	private Button cyanButton;
	public Item gray, cyan, pink;
	// Use this for initialization
	void Start () {
		pl = new Player ();
		this.textInventory = GameObject.Find ("InventoryItem").GetComponent<Text> ();
		grayButton = GameObject.Find ("Gray Button").GetComponent<Button> ();
		cyanButton = GameObject.Find ("Cyan Button").GetComponent<Button> ();
		pinkButton = GameObject.Find ("Pink Button").GetComponent<Button> ();
		this.textInventory.text = "None";

		gray = new Item ("gray");
		cyan = new Item ("cyan");
		pink = new Item ("pink");

		buttonMap.Add (grayButton, gray);
		buttonMap.Add (pinkButton, pink);
		buttonMap.Add (cyanButton, cyan);

		grayButton.onClick.AddListener (()=>itemClicked(grayButton));
		pinkButton.onClick.AddListener (()=>itemClicked(pinkButton));
		cyanButton.onClick.AddListener (()=>itemClicked(cyanButton));
		
	}

	public void itemClicked(Button buttonPressed)
	{
		pl.AddItem (buttonMap [buttonPressed]);
		buttonPressed.interactable = false;
		this.textInventory.text = pl.ShowInventory ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
