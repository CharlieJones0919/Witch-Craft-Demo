using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class BuyTrade : MonoBehaviour, IPointerClickHandler {
	// ^ Declaring that the indented code is part of the "BuyTrade" class and that it will be using the pointer click handler. 

	public Sprite NothingImage;

	public Toggle MarkSlot1;
	public Image MSlot1Image;
	public Toggle MarkSlot2;
	public Image MSlot2Image;
	public Toggle MarkSlot3;
	public Image MSlot3Image;
	public Toggle MarkSlot4;
	public Image MSlot4Image;
	public Toggle MarkSlot5;
	public Image MSlot5Image;

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

	public GameObject BuyConfirmPanel;
	public GameObject BuyDenialPanel;

	// ^ Declaring all the game objects and variables this script will be using. (In the editor mode I will have dragged the objects these refer to from the hierarchy into the script via the inspector).

	///////////////////////////////////////////////////////////// BUYING ITEMS VALIDATION /////////////////////////////////////////////////////////////
	public void OnPointerClick(PointerEventData eventData) {
		// ^ The indented code will be run when the user clicks the object this script is attached to. It's attached to the "Yes" button on the BuyConfirm panel so it'll run whenever that's clicked.

		////////////// SLOT 1 (TURNIP SEEDS) BUY //////////////
		if (MarkSlot1.isOn == true && (MoneyStart.MoneyValue >= 100f)) {
			/// ^ These state that the indented code will only be run if the market item toggle that has last been clicked, which sets their ".isOn" bool to true, AND the user's MoneyValue variable must be more or equal to 100 -
			/// -(the price of the item stored in this toggle). The float "MoneyValue" was declared in the script and class "MoneyStart" so it's being referenced from there.

			MoneyStart.MoneyValue = MoneyStart.MoneyValue - 100f;
			// When the user clicks the "Yes" button on the "BuyConfirm" panel AND the statement's conditions on lines 49 and 53 are true (both the conditional statements this code is indented in), then the following code will run.
			MarkSlot1.interactable = false;
			// ^ If the user has "bought" the item stored as an image in this slot, the toggle will become disabled so the user can't buy another.
			MarkSlot1.isOn = false;
			// ^ The toggle has been turned on from the user clicking it so this turns it off again to make the condidtions for this script being run the same when a toggle is next clicked.

			if (TInvSlot1Image.sprite == NothingImage) {
				TInvSlot1Image.sprite = MSlot1Image.sprite;
			} else	if (TInvSlot2Image.sprite == NothingImage) {
				TInvSlot2Image.sprite = MSlot1Image.sprite;
			} else	if (TInvSlot3Image.sprite == NothingImage) {
				TInvSlot3Image.sprite = MSlot1Image.sprite;
			} else 	if (TInvSlot4Image.sprite == NothingImage) {
				TInvSlot4Image.sprite = MSlot1Image.sprite;
			} else if (TInvSlot5Image.sprite == NothingImage) {
				TInvSlot5Image.sprite = MSlot1Image.sprite;
			} else 	if (TInvSlot6Image.sprite == NothingImage) {
				TInvSlot6Image.sprite = MSlot1Image.sprite;
			} 
			/// ^ These statements check that if one of the user's inventory spaces are "empty", from if their image value is the same as the defined "Nothing Image" (just a blank PNG) that the image stored in the toggle-
			/// - the user last clicked on will be made the inventory space's new image sprite. It checks all the slots in case there's already a different image or object being stored in it.
		
		} else	if (MarkSlot1.isOn == true && (MoneyStart.MoneyValue < 100f)) {
			BuyDenialPanel.active = true;
			// ^ If the user's MoneyValue float is less than 100 (the price of the item stored in this statement's toggle), they will instead be directed to the BuyDenialPanel or screen when they click the "Yes" button.
		}

		////////////// SLOT 2 (PUMPKIN SEEDS) BUY //////////////
		if (MarkSlot2.isOn == true && (MoneyStart.MoneyValue >= 500f)) {
			MoneyStart.MoneyValue = MoneyStart.MoneyValue - 500f;
			MarkSlot2.interactable = false;
			MarkSlot1.isOn = false;

			if (TInvSlot1Image.sprite == NothingImage) {
				TInvSlot1Image.sprite = MSlot2Image.sprite;
			} else	if (TInvSlot2Image.sprite == NothingImage) {
				TInvSlot2Image.sprite = MSlot2Image.sprite;
			} else	if (TInvSlot3Image.sprite == NothingImage) {
				TInvSlot3Image.sprite = MSlot2Image.sprite;
			} else if (TInvSlot4Image.sprite == NothingImage) {
				TInvSlot4Image.sprite = MSlot2Image.sprite;
			} else	if (TInvSlot5Image.sprite == NothingImage) {
				TInvSlot5Image.sprite = MSlot2Image.sprite;
			} 	else if (TInvSlot6Image.sprite == NothingImage) {
				TInvSlot6Image.sprite = MSlot2Image.sprite;
			} 
		} else if (MarkSlot2.isOn == true && (MoneyStart.MoneyValue < 500f)) {
			BuyDenialPanel.active = true;
		}

		// ^ The same as the last "SLOT *SlotNumber* (*Item*) BUY" code but for another market toggle with another price.

		////////////// SLOT 3 (NEEBLE SEEDS) BUY //////////////
		if (MarkSlot3.isOn == true && (MoneyStart.MoneyValue >= 1500f)) {
			MoneyStart.MoneyValue = MoneyStart.MoneyValue - 1500f;
			MarkSlot3.interactable = false;
			MarkSlot1.isOn = false;

			if (TInvSlot1Image.sprite == NothingImage) {
				TInvSlot1Image.sprite = MSlot3Image.sprite;
			} else	if (TInvSlot2Image.sprite == NothingImage) {
				TInvSlot2Image.sprite = MSlot3Image.sprite;
			} else if (TInvSlot3Image.sprite == NothingImage) {
				TInvSlot3Image.sprite = MSlot3Image.sprite;
			} else if (TInvSlot4Image.sprite == NothingImage) {
				TInvSlot4Image.sprite = MSlot3Image.sprite;
			} else if (TInvSlot5Image.sprite == NothingImage) {
				TInvSlot5Image.sprite = MSlot3Image.sprite;
			} else 	if (TInvSlot6Image.sprite == NothingImage) {
				TInvSlot6Image.sprite = MSlot3Image.sprite;
			} 
		} else if (MarkSlot3.isOn == true && (MoneyStart.MoneyValue < 1500f)) {
			BuyDenialPanel.active = true;
		}

		////////////// SLOT 4 (GARDEN HOE) BUY //////////////
		if (MarkSlot4.isOn == true && (MoneyStart.MoneyValue >= 20f)) {
			MoneyStart.MoneyValue = MoneyStart.MoneyValue - 20f;
			MarkSlot4.interactable = false;
			MarkSlot1.isOn = false;

			if (TInvSlot1Image.sprite == NothingImage) {
				TInvSlot1Image.sprite = MSlot4Image.sprite;
			} else if (TInvSlot2Image.sprite == NothingImage) {
				TInvSlot2Image.sprite = MSlot4Image.sprite;
			} else if (TInvSlot3Image.sprite == NothingImage) {
				TInvSlot3Image.sprite = MSlot4Image.sprite;
			} else if (TInvSlot4Image.sprite == NothingImage) {
				TInvSlot4Image.sprite = MSlot4Image.sprite;
			} else if (TInvSlot5Image.sprite == NothingImage) {
				TInvSlot5Image.sprite = MSlot4Image.sprite;
			} else	if (TInvSlot6Image.sprite == NothingImage) {
				TInvSlot6Image.sprite = MSlot4Image.sprite;
			} 
		} else if (MarkSlot4.isOn == true && (MoneyStart.MoneyValue < 20f)) {
			BuyDenialPanel.active = true;
		}
	
		////////////// SLOT 5 (WATERING CAN) BUY //////////////
		if (MarkSlot5.isOn == true && (MoneyStart.MoneyValue >= 80f)) {
			MoneyStart.MoneyValue = MoneyStart.MoneyValue - 80f;
			MarkSlot5.interactable = false;
			MarkSlot1.isOn = false;

			if (TInvSlot1Image.sprite == NothingImage) {
				TInvSlot1Image.sprite = MSlot5Image.sprite;
			} else	if (TInvSlot2Image.sprite == NothingImage) {
				TInvSlot2Image.sprite = MSlot5Image.sprite;
			} else if (TInvSlot3Image.sprite == NothingImage) {
				TInvSlot3Image.sprite = MSlot5Image.sprite;
			} else	if (TInvSlot4Image.sprite == NothingImage) {
				TInvSlot4Image.sprite = MSlot5Image.sprite;
			} else	if (TInvSlot5Image.sprite == NothingImage) {
				TInvSlot5Image.sprite = MSlot5Image.sprite;
			} else	if (TInvSlot6Image.sprite == NothingImage) {
				TInvSlot6Image.sprite = MSlot5Image.sprite;
			}  
		} else if (MarkSlot5.isOn == true && (MoneyStart.MoneyValue < 80f)) {
			BuyDenialPanel.active = true;
		}	

		BuyConfirmPanel.active = false;
		// ^ In the inspector the BuyConfirmPanel gets set to ".active" (showing) when the user clicks a market item toggle. This turns it off again when the user clicks the "Yes" button on the BuyConfirm panel.
		InventorySlot1Image.sprite = TInvSlot1Image.sprite;
		InventorySlot2Image.sprite = TInvSlot2Image.sprite;
		InventorySlot3Image.sprite = TInvSlot3Image.sprite;
		InventorySlot4Image.sprite = TInvSlot4Image.sprite;
		InventorySlot5Image.sprite = TInvSlot5Image.sprite;
		InventorySlot6Image.sprite = TInvSlot6Image.sprite;
		// ^ These statements set the inventory slot images to have the same sprites stored in their image values as the trade scren image slots' sprites.
	}
}