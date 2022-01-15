using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class SellTrade : MonoBehaviour, IPointerClickHandler {
	// ^ Declaring that the indented code is part of the "SellTrade" class and that it will be using the pointer click handler. 
	public Sprite NothingImage;
	public Sprite HoeSprite;
	public Sprite WateringCanSprite;
	public Sprite TurnipSeedSprite;
	public Sprite PumpkinSeedSprite;
	public Sprite NeebleSeedSprite;
	public Sprite TurnipCropSprite;
	public Sprite PumpkinCropSprite;

	public Toggle TInvSlot1Toggle;
	public Image TInvSlot1Image;
	public Toggle TInvSlot2Toggle;
	public Image TInvSlot2Image;
	public Toggle TInvSlot3Toggle;
	public Image TInvSlot3Image;
	public Toggle TInvSlot4Toggle;
	public Image TInvSlot4Image;
	public Toggle TInvSlot5Toggle;
	public Image TInvSlot5Image;
	public Toggle TInvSlot6Toggle;
	public Image TInvSlot6Image;

	public Image InventorySlot1Image;
	public Image InventorySlot2Image;
	public Image InventorySlot3Image;
	public Image InventorySlot4Image;
	public Image InventorySlot5Image;
	public Image InventorySlot6Image;

	public GameObject SellConfirmPanel;
	public GameObject SellDenialPanel;
	// ^ Declaring all the game objects and variables this script will be using. (In the editor mode I will have dragged the objects these refer to from the hierarchy into the script via the inspector).

	///////////////////////////////////////////////////////////// SELLING ITEMS VALIDATION /////////////////////////////////////////////////////////////
	public void OnPointerClick(PointerEventData eventData) {
	// ^ The indented code will be run when the user clicks the object this script is attached to. It's attached to the "Yes" button on the SellConfirm panel so it'll run whenever that's clicked.

		////////////// SLOT 1 SELL //////////////
		if (TInvSlot1Toggle.isOn == true) {
			// ^ The following indented code will be executed if a TradeMenuPanel's Inventory toggle is on.

			TInvSlot1Toggle.isOn = false;
			// ^ The toggle has been turned on from the user clicking it so this turns it off again to make the condidtions for this script being run the same when a toggle is next clicked.

			if (TInvSlot1Image.sprite == HoeSprite) {
				SellDenialPanel.active = true;
				// ^ If the image sprite of the toggle that the user has turned on is the HoeSprite sprite the SellDenialPanel will be set active or visable.
			} else if (TInvSlot1Image.sprite == WateringCanSprite) {
				SellDenialPanel.active = true;
				// ^ If the image sprite of the toggle that the user has turned on is the WateringCanSprite sprite the SellDenialPanel will be set active or visable.
			} else if (TInvSlot1Image.sprite == TurnipSeedSprite) {
				SellDenialPanel.active = true;
				// ^ If the image sprite of the toggle that the user has turned on is the TurnipSeedSprite sprite the SellDenialPanel will be set active or visable.
			} else if (TInvSlot1Image.sprite == PumpkinSeedSprite) {
				SellDenialPanel.active = true;
				// ^ If the image sprite of the toggle that the user has turned on is the PumpkinSeedSprite sprite the SellDenialPanel will be set active or visable.
			} else if (TInvSlot1Image.sprite == NeebleSeedSprite) {
				SellDenialPanel.active = true;
				// ^ If the image sprite of the toggle that the user has turned on is the NeebleSeedSprite sprite the SellDenialPanel will be set active or visable.
			} else if (TInvSlot1Image.sprite == NothingImage) {
				SellDenialPanel.active = true;
				// ^ If the image sprite of the toggle that the user has turned on is the NothingImage sprite the SellDenialPanel will be set active or visable.
			} else if (TInvSlot1Image.sprite == TurnipCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 500f;
				TInvSlot1Image.sprite = NothingImage;
				// ^ If the image sprite of the toggle that the user has turned on is the TurnipCropSprite sprite then the user's MoneyValue (which is being referenced from the MoneyStart class) will be increased by 500 and the toggle image sprite will be -
				// -set to equal the NothingImage sprite as they have sold the item in that toggle.
			} else if (TInvSlot1Image.sprite == PumpkinCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 1500f;
				TInvSlot1Image.sprite = NothingImage;
				// ^ Same as lines 73 to 75 but for the PumpkinCropSprite sprite.
			}
		}

		////////////// SLOT 2 SELL //////////////
		if (TInvSlot2Toggle.isOn == true) {
			TInvSlot2Toggle.isOn = false;

			if (TInvSlot2Image.sprite == HoeSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot2Image.sprite == WateringCanSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot2Image.sprite == TurnipSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot2Image.sprite == PumpkinSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot2Image.sprite == NeebleSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot2Image.sprite == NothingImage) {
				SellDenialPanel.active = true;
			} else if (TInvSlot2Image.sprite == TurnipCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 500f;
				TInvSlot2Image.sprite = NothingImage;
			} else if (TInvSlot2Image.sprite == PumpkinCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 1500f;
				TInvSlot2Image.sprite = NothingImage;
			}
		}
		// ^ The same as the last "SLOT *SlotNumber* (*Item*) SELL" code but for another inventory toggle.

		////////////// SLOT 3 SELL //////////////
		if (TInvSlot3Toggle.isOn == true) {
			TInvSlot3Toggle.isOn = false;

			if (TInvSlot3Image.sprite == HoeSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot3Image.sprite == WateringCanSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot3Image.sprite == TurnipSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot3Image.sprite == PumpkinSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot3Image.sprite == NeebleSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot3Image.sprite == NothingImage) {
				SellDenialPanel.active = true;
			} else if (TInvSlot3Image.sprite == TurnipCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 500f;
				TInvSlot3Image.sprite = NothingImage;
			} else if (TInvSlot3Image.sprite == PumpkinCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 1500f;
				TInvSlot3Image.sprite = NothingImage;
			}
		}
		// ^ The same as the last "SLOT *SlotNumber* (*Item*) SELL" code but for another inventory toggle.

		////////////// SLOT 4 SELL //////////////
		if (TInvSlot4Toggle.isOn == true) {
			TInvSlot4Toggle.isOn = false;

			if (TInvSlot4Image.sprite == HoeSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot4Image.sprite == WateringCanSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot4Image.sprite == TurnipSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot4Image.sprite == PumpkinSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot4Image.sprite == NeebleSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot4Image.sprite == NothingImage) {
				SellDenialPanel.active = true;
			} else if (TInvSlot4Image.sprite == TurnipCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 500f;
				TInvSlot4Image.sprite = NothingImage;
			} else if (TInvSlot4Image.sprite == PumpkinCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 1500f;
				TInvSlot4Image.sprite = NothingImage;
			}
		}
		// ^ The same as the last "SLOT *SlotNumber* (*Item*) SELL" code but for another inventory toggle.

		////////////// SLOT 5 SELL //////////////
		if (TInvSlot5Toggle.isOn == true) {
			TInvSlot5Toggle.isOn = false;

			if (TInvSlot5Image.sprite == HoeSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot5Image.sprite == WateringCanSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot5Image.sprite == TurnipSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot5Image.sprite == PumpkinSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot5Image.sprite == NeebleSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot5Image.sprite == NothingImage) {
				SellDenialPanel.active = true;
			} else if (TInvSlot5Image.sprite == TurnipCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 500f;
				TInvSlot5Image.sprite = NothingImage;
			} else if (TInvSlot5Image.sprite == PumpkinCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 1500f;
				TInvSlot5Image.sprite = NothingImage;
			}
		}
		// ^ The same as the last "SLOT *SlotNumber* (*Item*) SELL" code but for another inventory toggle.

		////////////// SLOT 6 SELL //////////////
		if (TInvSlot6Toggle.isOn == true) {
			TInvSlot6Toggle.isOn = false;

			if (TInvSlot6Image.sprite == HoeSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot6Image.sprite == WateringCanSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot6Image.sprite == TurnipSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot6Image.sprite == PumpkinSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot6Image.sprite == NeebleSeedSprite) {
				SellDenialPanel.active = true;
			} else if (TInvSlot6Image.sprite == NothingImage) {
				SellDenialPanel.active = true;
			} else if (TInvSlot6Image.sprite == TurnipCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 500f;
				TInvSlot6Image.sprite = NothingImage;
			} else if (TInvSlot6Image.sprite == PumpkinCropSprite) {
				MoneyStart.MoneyValue = MoneyStart.MoneyValue + 1500f;
				TInvSlot6Image.sprite = NothingImage;
			}
		}
		// ^ The same as the last "SLOT *SlotNumber* (*Item*) SELL" code but for another inventory toggle.

		SellConfirmPanel.active = false;
		// ^ In the inspector the SellConfirmPanel gets set to ".active" (showing) when the user clicks an inventory item toggle. This turns it off again when the user clicks the "Yes" button on the SellConfirm panel.
		InventorySlot1Image.sprite = TInvSlot1Image.sprite;
		InventorySlot2Image.sprite = TInvSlot2Image.sprite;
		InventorySlot3Image.sprite = TInvSlot3Image.sprite;
		InventorySlot4Image.sprite = TInvSlot4Image.sprite;
		InventorySlot5Image.sprite = TInvSlot5Image.sprite;
		InventorySlot6Image.sprite = TInvSlot6Image.sprite;
		// ^ These statements set the inventory slot images to have the same sprites stored in their image values as the trade scren image slots' sprites.
	}
}
