using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class InventoryItemEquipped : MonoBehaviour {
	// ^ Declares that the indented code is part of the "InventoryItemEquipped" class. 

	public Toggle InventorySlot1;
	public Toggle InventorySlot2;
	public Toggle InventorySlot3;
	public Toggle InventorySlot4;
	public Toggle InventorySlot5;
	public Toggle InventorySlot6;
	// ^ Declaring all the game objects and variables this script will be using. (In the editor mode I will have dragged the objects these refer to from the hierarchy into the script via the inspector).

	void Update () {
		// ^ When this object first becomes active or "Starts" the indented code will be iterated repeatedly at regular intervals.
		InventorySlotCheck ();
	}
		
	void InventorySlotCheck () {
	/////// SLOT 1 EQUIPPING ///////
		if (InventorySlot1.isOn) {
			InventorySlot1.image.color = Color.grey;
			// ^ Keeps the toggles in a darker colour when on so the user knows which slot is active or "equipped".
		} else {
			InventorySlot1.image.color = Color.white;
			// ^ If the toggle isn't on it will remain its normal colour.
		}

	/////// SLOT 2 EQUIPPING ///////
		if (InventorySlot2.isOn) {
			InventorySlot2.image.color = Color.grey;
		} else {
			InventorySlot2.image.color = Color.white;
		}

	/////// SLOT 3 EQUIPPING ///////
		if (InventorySlot3.isOn) {
			InventorySlot3.image.color = Color.grey;
		} else {
			InventorySlot3.image.color = Color.white;
		}

	/////// SLOT 4 EQUIPPING ///////
		if (InventorySlot4.isOn) {
			InventorySlot4.image.color = Color.grey;
		} else {
			InventorySlot4.image.color = Color.white;
		}

	/////// SLOT 5 EQUIPPING ///////
		if (InventorySlot5.isOn) {
			InventorySlot5.image.color = Color.grey;
		} else {
			InventorySlot5.image.color = Color.white;
		}

	/////// SLOT 6 EQUIPPING ///////
		if (InventorySlot6.isOn) {
			InventorySlot6.image.color = Color.grey;
		} else {
			InventorySlot6.image.color = Color.white;
		}
	}
}