using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class InvSlotValueToDesc : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
	// ^ Declares that the indented code is part of the "BuyTrade" class and that it will be used the pointer enter and pointer exit handlers (when the cursor is hovering over or leaving the object).  

	public Sprite NothingSprite;
	public Sprite HoeSprite;
	public Sprite WateringCanSprite;
	public Sprite TurnipSeedSprite;
	public Sprite PumpkinSeedSprite;
	public Sprite NeebleSeedSprite;
	public Sprite TurnipCropSprite;
	public Sprite PumpkinCropSprite;

	public Image InvSlotImage;

	public Text InventoryItemName;
	public Text InventoryItemPrice;
	public Text InventoryItemDesc;
	// ^ Declaring all the game objects and variables this script will be using. (In the editor mode I will have dragged the objects these refer to from the hierarchy into the script via the inspector).

	public void OnPointerEnter(PointerEventData eventData) {
	// ^ The indented code will be run when the user's cursor hovers over the object this script is attached to. It's attached to the all of the Inventory Toggles on the TradeMenu panel but the public object "InvSlotImage" -
	// -will be set equal to the image for each individual toggle it's attached to in each toggle's properties inspector.

	/// ITEM NAME CHECK ///
		if (InvSlotImage.sprite == HoeSprite) {
			InventoryItemName.text = "GARDENING HOE";
			// ^ If the user is hovering over the toggle with the HoeSprite as its image's sprite then the Name text in the item description box of the TradeMenu will say "GARDENING HOE".
		} else if (InvSlotImage.sprite == WateringCanSprite) {
			InventoryItemName.text = "WATERING CAN";
			// ^ If the user is hovering over the toggle with the WateringCanSprite as its image's sprite then the Name text in the item description box of the TradeMenu will say "WATERING CAN" ect. for the rest.
		} else if (InvSlotImage.sprite == TurnipSeedSprite) {
			InventoryItemName.text = "TURNIP SEED";
		} else if (InvSlotImage.sprite == PumpkinSeedSprite) {
			InventoryItemName.text = "PUMPKIN SEED";
		} else if (InvSlotImage.sprite == NeebleSeedSprite) {
			InventoryItemName.text = "NEEBLE SEED";
		} else if (InvSlotImage.sprite == TurnipCropSprite) {
			InventoryItemName.text = "TURNIP CROP";
		} else if (InvSlotImage.sprite == PumpkinCropSprite) {
			InventoryItemName.text = "PUMPKIN CROP";
		} else if (InvSlotImage.sprite == NothingSprite) {
			InventoryItemName.text = "---";
		}

		/// ITEM PRICE CHECK ///
		if (InvSlotImage.sprite == HoeSprite) {
			InventoryItemPrice.text = "20";
		} else if (InvSlotImage.sprite == WateringCanSprite) {
			InventoryItemPrice.text = "80";
		} else if (InvSlotImage.sprite == TurnipSeedSprite) {
			InventoryItemPrice.text = "100";
		} else if (InvSlotImage.sprite == PumpkinSeedSprite) {
			InventoryItemPrice.text = "20";
		} else if (InvSlotImage.sprite == NeebleSeedSprite) {
			InventoryItemPrice.text = "20";
		} else if (InvSlotImage.sprite == TurnipCropSprite) {
			InventoryItemPrice.text = "500";
		} else if (InvSlotImage.sprite == PumpkinCropSprite) {
			InventoryItemPrice.text = "1500";
		} else if (InvSlotImage.sprite == NothingSprite) {
			InventoryItemPrice.text = "---";
		}
		// ^ The same as the "ITEM NAME CHECK" conditions but for making the description box's price texts.

		/// ITEM DESC CHECK ///
		if (InvSlotImage.sprite == HoeSprite) {
			InventoryItemDesc.text = "A hoe can be used to till the earth for seeds to be planted in.";
		} else if (InvSlotImage.sprite == WateringCanSprite) {
			InventoryItemDesc.text = "Seeds must be watered with a watering can to start growing.";
		} else if (InvSlotImage.sprite == TurnipSeedSprite) {
			InventoryItemDesc.text = "Turnips grow quickly but produce a common and cheap selling crop.";
		} else if (InvSlotImage.sprite == PumpkinSeedSprite) {
			InventoryItemDesc.text = "Pumpkins grow slowly put produce a very profitable crop.";
		} else if (InvSlotImage.sprite == NeebleSeedSprite) {
			InventoryItemDesc.text = "Neeble seeds grow at unpredictable speeds. Harvest them quickly or they'll run away.";
		} else if (InvSlotImage.sprite == TurnipCropSprite) {
			InventoryItemDesc.text = "A freshly harvested turnip. You'll be the bane of the Turnip King.";
		} else if (InvSlotImage.sprite == PumpkinCropSprite) {
			InventoryItemDesc.text = "A lovely fresh pumpkin. Depending on the season you're either ready for Halloween or REALLY ready for Halloween.";
		} else if (InvSlotImage.sprite == NothingSprite) {
			InventoryItemDesc.text = "---";
		}
		// ^ The same as the "ITEM NAME CHECK" conditions but for making the description box's description texts.
	}

	public void OnPointerExit(PointerEventData eventData) {
			InventoryItemName.text = "";
			InventoryItemPrice.text = "0";
			InventoryItemDesc.text = "";
		// ^ When the user's cursor leaves the toggle object's area the description box text values are set to nothing and 0 for price.
	}
}
