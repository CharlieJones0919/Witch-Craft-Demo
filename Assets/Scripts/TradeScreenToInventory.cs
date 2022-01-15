using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class TradeScreenToInventory : MonoBehaviour {
	// ^ Declares that the indented code is part of the "TradeScreenToInventory" class. 

	public GameObject TradeMenu;

	public Image TInvSlot1Image;
	public Image TInvSlot2Image;
	public Image TInvSlot3Image;
	public Image TInvSlot4Image;
	public Image TInvSlot5Image;
	public Image TInvSlot6Image;

	public Image InventorySlot1Image;
	public Image InventorySlot2Image;
	public Image InventorySlot3Image;
	public Image InventorySlot4Image;
	public Image InventorySlot5Image;
	public Image InventorySlot6Image;
	// ^ Declaring all the game objects and variables this script will be using. (In the editor mode I will have dragged the objects these refer to from the hierarchy into the script via the inspector).

	void Update () {
	// ^ When this object first becomes active or "Starts" the indented code will be iterated repeatedly at regular intervals.
		if (TradeMenu.active == true) {
			TInvSlot1Image.sprite = InventorySlot1Image.sprite;
			TInvSlot2Image.sprite = InventorySlot2Image.sprite;
			TInvSlot3Image.sprite = InventorySlot3Image.sprite;
			TInvSlot4Image.sprite = InventorySlot4Image.sprite;
			TInvSlot5Image.sprite = InventorySlot5Image.sprite;
			TInvSlot6Image.sprite = InventorySlot6Image.sprite;
		}
		// ^ If the TradeMenu is active or showing the trade inventory toggle's image sprites will be set equal to the HutPanel's inventory toggle image sprites.
	}
}
