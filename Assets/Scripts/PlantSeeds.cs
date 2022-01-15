using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class PlantSeeds : MonoBehaviour, IPointerClickHandler {
	// ^ Declaring that the indented code is part of the "PlantSeeds" class and that it will be using the pointer click handler. 

	public Sprite NothingImage;
	public Sprite HoeSprite;
	public Sprite WateringCanSprite;
	public Sprite TurnipSeedSprite;
	public Sprite PumpkinSeedSprite;
	public Sprite NeebleSeedSprite;
	public Sprite TurnipCropSprite;
	public Sprite PumpkinCropSprite;
	public Sprite NeebleCropSprite;

	public Image PlantBoxSoil;
	public Sprite SoilStart;
	public Sprite SoilTilled;
	public Sprite SoilWatered;

	public Animator CropSprite;

	public Text LVLLEVELText;
	public Text EXPLEVELText;
	public int LVLLEVEL;
	public int EXPLEVEL;

	public Toggle InventorySlot1Toggle;
	public Image InventorySlot1Image;
	public Toggle InventorySlot2Toggle;
	public Image InventorySlot2Image;
	public Toggle InventorySlot3Toggle;
	public Image InventorySlot3Image;
	public Toggle InventorySlot4Toggle;
	public Image InventorySlot4Image;
	public Toggle InventorySlot5Toggle;
	public Image InventorySlot5Image;
	public Toggle InventorySlot6Toggle;
	public Image InventorySlot6Image;

	public float HarvestCountdown;
	public Text HarvestCountdownText;

	public GameObject EndDemoPanel;
	// ^ Declaring all the game objects and variables this script will be using. (In the editor mode I will have dragged the objects these refer to from the hierarchy into the script via the inspector).

	public void Start () {
		CropSprite = GetComponent<Animator> ();
	}
	// ^ When this object first becomes active or "Starts", the variable "CropSprite" will be set equal to the animator assigned to it so it can be referenced in this script.

	public void Update () {
	// ^ When this object first becomes active or "Starts" the indented code will be iterated repeatedly at regular intervals.
		CropSprite.SetFloat ("CropGrowthCountdown", HarvestCountdown);
		// ^ The boolean animator parameter "CropGrowthCountdown" is equal to the float variable "HarvestCountdown".
		HarvestCountdownText.text = HarvestCountdown.ToString("F0");
		// ^ The HarvestCountdown text (top left text of the plant box) equals the value of the float variable "HarvestCountdown" as a string but with 0 decimal places.
		EXPLEVELText.text = EXPLEVEL.ToString();
		// ^ The EXPLEVELText text (top right of the game screen in blue) equals the value of the float variable "EXPLEVEL" as a string.
		LVLLEVELText.text = LVLLEVEL.ToString();
		// ^ The LVLLEVELText text (top right of the game screen in green) equals the value of the float variable "LVLLEVEL" as a string.

		if (CropSprite.GetBool("CropWatered") == true) {
			HarvestCountdown -= Time.deltaTime;
		}
		// ^ If the boolean animator parameter "CropWatered" currently equals true then the time is subtracted from the HarvestCountdown float variable and the countdown starts counting down.

		if (HarvestCountdown < 0) {
			HarvestCountdown = 0;
			CropSprite.SetBool("CropWatered", false);
			CropSprite.SetBool("CropFinished", true);
			PlantBoxSoil.sprite = SoilStart;
		}
		// ^ If the HarvestCountdown float variable equals less than 0 the the float is set to 0 (because the Update void isn't always fast enough on the uptake and sometimes goes lower) and the boolean animator parameter "CropWatered" is set equal -
		// -to false so the animator can move on. The CropFinished boolean parameter is set equal to true so the animator's conditions can be met to move onto the next animation stage and the PlantBoxSoil image's sprite is set back to the SoilStart -
		// -sprite for the next seeds. (The animator states will be further shown/explained in the game documentation).

		if (EXPLEVEL >= 300) {
			LVLLEVEL = 1;
		}
		// ^ If the float variable EXPLEVEL equals more or the same as 300 then the float variable LVLLEVEL is set equal to 1.

		if ((CropSprite.GetBool ("CropFinished") == true) && (CropSprite.GetComponent<Image> ().sprite == NeebleCropSprite)) {
			CropSprite.SetBool ("GameDemoOver", true);
		}
		// ^ If the boolean animator parameter "CropFinished" currently equals true AND the CropSprite animator image's sprite is the NeebleCropSprite then the  boolean animator parameter "GameDemoOver" is set equal to true.
	}
		
	public void OnPointerClick(PointerEventData eventData) {
		// ^ The indented code will be run when the user clicks the object this script is attached to. It's attached to the PlantBox image on the Hut panel so it'll run whenever that's clicked.

		////////////// Tilling the Soil //////////////
		if ((InventorySlot1Toggle.isOn) && (PlantBoxSoil.sprite == SoilStart) && (InventorySlot1Image.sprite == HoeSprite)) {
			// ^ If the user has turned on an inventory toggle AND the PlantBox image's sprite is the same as the SoilStart sprite AND the toggle they've turned on's image sprite is the HoeSprite then the following indented code will be executed.
			CropSprite.SetBool ("CropTaken", false);
			// ^ The boolean animator parameter "CropTaken" is set equal to false so the animator's conditions can be met to move onto the next animation stage and won't stay in the same current state.
			InventorySlot1Toggle.isOn = false;
			// ^ The inventory toggle the user turned on will be turned off as they have used the item inside.
			PlantBoxSoil.sprite = SoilTilled;
			// ^ The PlantBoxSoil image sprite is set equal to the SoilTilled sprite.
		}
		if ((InventorySlot2Toggle.isOn) && (PlantBoxSoil.sprite == SoilStart) && (InventorySlot2Image.sprite == HoeSprite)) {
			CropSprite.SetBool ("CropTaken", false);
			InventorySlot2Toggle.isOn = false;
			PlantBoxSoil.sprite = SoilTilled;
		}
		if ((InventorySlot3Toggle.isOn) && (PlantBoxSoil.sprite == SoilStart) && (InventorySlot3Image.sprite == HoeSprite)) {
			CropSprite.SetBool ("CropTaken", false);
			InventorySlot3Toggle.isOn = false;
			PlantBoxSoil.sprite = SoilTilled;
		}
		if ((InventorySlot4Toggle.isOn) && (PlantBoxSoil.sprite == SoilStart) && (InventorySlot4Image.sprite == HoeSprite)) {
			CropSprite.SetBool ("CropTaken", false);
			InventorySlot4Toggle.isOn = false;
			PlantBoxSoil.sprite = SoilTilled;
		}
		if ((InventorySlot5Toggle.isOn) && (PlantBoxSoil.sprite == SoilStart) && (InventorySlot5Image.sprite == HoeSprite)) {
			CropSprite.SetBool ("CropTaken", false);
			InventorySlot5Toggle.isOn = false;
			PlantBoxSoil.sprite = SoilTilled;
		}
		if ((InventorySlot6Toggle.isOn) && (PlantBoxSoil.sprite == SoilStart) && (InventorySlot6Image.sprite == HoeSprite)) {
			CropSprite.SetBool ("CropTaken", false);
			InventorySlot6Toggle.isOn = false;
			PlantBoxSoil.sprite = SoilTilled;
		}

		////////////// Planting a Seed //////////////
		/// TURNIP SEEDS ///
		if ((InventorySlot1Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot1Image.sprite == TurnipSeedSprite)) {
			// ^ If the user has turned on an inventory toggle AND the PlantBox image's sprite is the same as the SoilTilled sprite AND the toggle they've turned on's image sprite is the TurnipSeedSprite then the following indented code will be executed.
			InventorySlot1Toggle.isOn = false;
			// ^ The inventory toggle the user turned on will be turned off as they have used the item inside.
			InventorySlot1Image.sprite = NothingImage;
			// ^ The inventory toggle's image sprite is set equal to the NothingImage sprite as they have used the item inside and the Turnip Seeds aren't a reusable item.
			CropSprite.SetBool ("TurnipSeedsPlanted", true);
			// ^ The boolean animator parameter "TurnipSeedsPlanted" is set equal to true so the animator's conditions can be met to move onto the next animation stage and won't stay in the same current state.
			HarvestCountdown = 8;
			// ^ The float variable HarvestCountdown is set equal to 8.
		}
		if ((InventorySlot2Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot2Image.sprite == TurnipSeedSprite)) {
			InventorySlot2Toggle.isOn = false;
			InventorySlot2Image.sprite = NothingImage;
			CropSprite.SetBool ("TurnipSeedsPlanted", true);
			HarvestCountdown = 8;
		}
		if ((InventorySlot3Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot3Image.sprite == TurnipSeedSprite)) {
			InventorySlot3Toggle.isOn = false;
			InventorySlot3Image.sprite = NothingImage;
			CropSprite.SetBool ("TurnipSeedsPlanted", true);
			HarvestCountdown = 8;
		}
		if ((InventorySlot4Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot4Image.sprite == TurnipSeedSprite)) {
			InventorySlot4Toggle.isOn = false;
			InventorySlot4Image.sprite = NothingImage;
			CropSprite.SetBool ("TurnipSeedsPlanted", true);
			HarvestCountdown = 8;
		}
		if ((InventorySlot5Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot5Image.sprite == TurnipSeedSprite)) {
			InventorySlot5Toggle.isOn = false;
			InventorySlot5Image.sprite = NothingImage;
			CropSprite.SetBool ("TurnipSeedsPlanted", true);
			HarvestCountdown = 8;
		}
		if ((InventorySlot6Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot6Image.sprite == TurnipSeedSprite)) {
			InventorySlot6Toggle.isOn = false;
			InventorySlot6Image.sprite = NothingImage;
			CropSprite.SetBool ("TurnipSeedsPlanted", true);
			HarvestCountdown = 8;
		}

		/// PUMPKIN SEEDS ///
		if ((InventorySlot1Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot1Image.sprite == PumpkinSeedSprite)) {
			InventorySlot1Toggle.isOn = false;
			InventorySlot1Image.sprite = NothingImage;
			CropSprite.SetBool ("PumpkinSeedsPlanted", true);
			HarvestCountdown = 16;
		}
		if ((InventorySlot2Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot2Image.sprite == PumpkinSeedSprite)) {
			InventorySlot2Toggle.isOn = false;
			InventorySlot2Image.sprite = NothingImage;
			CropSprite.SetBool ("PumpkinSeedsPlanted", true);
			HarvestCountdown = 16;
		}
		if ((InventorySlot3Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot3Image.sprite == PumpkinSeedSprite)) {
			InventorySlot3Toggle.isOn = false;
			InventorySlot3Image.sprite = NothingImage;
			CropSprite.SetBool ("PumpkinSeedsPlanted", true);
			HarvestCountdown = 16;
		}
		if ((InventorySlot4Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot4Image.sprite == PumpkinSeedSprite)) {
			InventorySlot4Toggle.isOn = false;
			InventorySlot4Image.sprite = NothingImage;
			CropSprite.SetBool ("PumpkinSeedsPlanted", true);
			HarvestCountdown = 16;
		}
		if ((InventorySlot5Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot5Image.sprite == PumpkinSeedSprite)) {
			InventorySlot5Toggle.isOn = false;
			InventorySlot5Image.sprite = NothingImage;
			CropSprite.SetBool ("PumpkinSeedsPlanted", true);
			HarvestCountdown = 16;
		}
		if ((InventorySlot6Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot6Image.sprite == PumpkinSeedSprite)) {
			InventorySlot6Toggle.isOn = false;
			InventorySlot6Image.sprite = NothingImage;
			CropSprite.SetBool ("PumpkinSeedsPlanted", true);
			HarvestCountdown = 16;
		}
		// ^ Does the same as the "TURNIP SEEDS" code but for the Pumpkin Seeds.

		/// NEEBLE SEEDS ///
		if	 ((InventorySlot1Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot1Image.sprite == NeebleSeedSprite)) {
			InventorySlot1Toggle.isOn = false;
			InventorySlot1Image.sprite = NothingImage;
			CropSprite.SetBool("NeebleSeedsPlanted", true);
			HarvestCountdown = 24;
		}
		if ((InventorySlot2Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot2Image.sprite == NeebleSeedSprite)) {
			InventorySlot2Toggle.isOn = false;
			InventorySlot2Image.sprite = NothingImage;
			CropSprite.SetBool("NeebleSeedsPlanted", true);
			HarvestCountdown = 24;
		}
		if ((InventorySlot3Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot3Image.sprite == NeebleSeedSprite)) {
			InventorySlot3Toggle.isOn = false;
			InventorySlot3Image.sprite = NothingImage;
			CropSprite.SetBool("NeebleSeedsPlanted", true);
			HarvestCountdown = 24;
		}
		if ((InventorySlot4Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot4Image.sprite == NeebleSeedSprite)) {
			InventorySlot4Toggle.isOn = false;
			InventorySlot4Image.sprite = NothingImage;
			CropSprite.SetBool("NeebleSeedsPlanted", true);
			HarvestCountdown = 24;
		}
		if ((InventorySlot5Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot5Image.sprite == NeebleSeedSprite)) {
			InventorySlot5Toggle.isOn = false;
			InventorySlot5Image.sprite = NothingImage;
			CropSprite.SetBool("NeebleSeedsPlanted", true);
			HarvestCountdown = 24;
		}
		if ((InventorySlot6Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot6Image.sprite == NeebleSeedSprite)) {
			InventorySlot6Toggle.isOn = false;
			InventorySlot6Image.sprite = NothingImage;
			CropSprite.SetBool("NeebleSeedsPlanted", true);
			HarvestCountdown = 24;
		}
		// ^ Does the same as the "TURNIP SEEDS" code but for the Pumpkin Seeds.

		////////////// Watering the Crop //////////////
		if ((InventorySlot1Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot1Image.sprite == WateringCanSprite) && ((CropSprite.GetBool("TurnipSeedsPlanted") == true) || (CropSprite.GetBool("PumpkinSeedsPlanted") == true) || 
			(CropSprite.GetBool("NeebleSeedsPlanted") == true))) {
			// ^ If the user has turned on an inventory toggle AND the PlantBox image's sprite is the same as the SoilTilled sprite AND if any of the boolean animator parameters out of "TurnipSeedsPlanted", "PumpkinSeedsPlanted" and "NeebleSeedsPlanted" -
			// -equal true then the following indented code will be executed.
				InventorySlot1Toggle.isOn = false;
				// ^ The inventory toggle the user turned on will be turned off as they have used the item inside.
				CropSprite.SetBool("TurnipSeedsPlanted", false);
				CropSprite.SetBool("PumpkinSeedsPlanted", false);
				CropSprite.SetBool("NeebleSeedsPlanted", false);
				// ^ The boolean animator parameters "TurnipSeedsPlanted", "PumpkinSeedsPlanted" and "NeebleSeedsPlanted" are all set equal to false so the animator's conditions can be met to move onto the next animation stage.

				PlantBoxSoil.sprite = SoilWatered;
				// ^ The PlantBoxSoil image sprite is set equal to the SoilWatered sprite.
				CropSprite.SetBool("CropWatered", true);
				// ^ The boolean animator parameter "CropWatered" is set equal to true so the animator's conditions can be met to move onto the next animation stage.
		}
		if ((InventorySlot2Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot2Image.sprite == WateringCanSprite) && ((CropSprite.GetBool("TurnipSeedsPlanted") == true) || (CropSprite.GetBool("PumpkinSeedsPlanted") == true) || 
			(CropSprite.GetBool("NeebleSeedsPlanted") == true))) {
				InventorySlot2Toggle.isOn = false;
				CropSprite.SetBool("TurnipSeedsPlanted", false);
				CropSprite.SetBool("PumpkinSeedsPlanted", false);
				CropSprite.SetBool("NeebleSeedsPlanted", false);

				PlantBoxSoil.sprite = SoilWatered;
				CropSprite.SetBool("CropWatered", true);
		}
		if ((InventorySlot3Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot3Image.sprite == WateringCanSprite) && ((CropSprite.GetBool("TurnipSeedsPlanted") == true) || (CropSprite.GetBool("PumpkinSeedsPlanted") == true) || 
			(CropSprite.GetBool("NeebleSeedsPlanted") == true))) {
				InventorySlot3Toggle.isOn = false;
				CropSprite.SetBool("TurnipSeedsPlanted", false);
				CropSprite.SetBool("PumpkinSeedsPlanted", false);
				CropSprite.SetBool("NeebleSeedsPlanted", false);

				PlantBoxSoil.sprite = SoilWatered;
				CropSprite.SetBool("CropWatered", true);
		}
		if ((InventorySlot4Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot4Image.sprite == WateringCanSprite) && ((CropSprite.GetBool("TurnipSeedsPlanted") == true) || (CropSprite.GetBool("PumpkinSeedsPlanted") == true) || 
			(CropSprite.GetBool("NeebleSeedsPlanted") == true))) {
				InventorySlot4Toggle.isOn = false;
				CropSprite.SetBool("TurnipSeedsPlanted", false);
				CropSprite.SetBool("PumpkinSeedsPlanted", false);
				CropSprite.SetBool("NeebleSeedsPlanted", false);

				PlantBoxSoil.sprite = SoilWatered;
				CropSprite.SetBool("CropWatered", true);
		}
		if ((InventorySlot5Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot5Image.sprite == WateringCanSprite) && ((CropSprite.GetBool("TurnipSeedsPlanted") == true) || (CropSprite.GetBool("PumpkinSeedsPlanted") == true) || 
			(CropSprite.GetBool("NeebleSeedsPlanted") == true))) {
				InventorySlot5Toggle.isOn = false;
				CropSprite.SetBool("TurnipSeedsPlanted", false);
				CropSprite.SetBool("PumpkinSeedsPlanted", false);
				CropSprite.SetBool("NeebleSeedsPlanted", false);

				PlantBoxSoil.sprite = SoilWatered;
				CropSprite.SetBool("CropWatered", true);
		}
		if ((InventorySlot6Toggle.isOn) && (PlantBoxSoil.sprite == SoilTilled) && (InventorySlot6Image.sprite == WateringCanSprite) && ((CropSprite.GetBool("TurnipSeedsPlanted") == true) || (CropSprite.GetBool("PumpkinSeedsPlanted") == true) || 
			(CropSprite.GetBool("NeebleSeedsPlanted") == true))) {
				InventorySlot6Toggle.isOn = false;
				CropSprite.SetBool("TurnipSeedsPlanted", false);
				CropSprite.SetBool("PumpkinSeedsPlanted", false);
				CropSprite.SetBool("NeebleSeedsPlanted", false);

				PlantBoxSoil.sprite = SoilWatered;
				CropSprite.SetBool("CropWatered", true);
		}

		////////////// Harvesting the Crop //////////////
		/// TURNIP HARVEST ///
		if ((CropSprite.GetBool("CropFinished") == true) && (CropSprite.GetComponent<Image>().sprite == TurnipCropSprite)) {
		// ^ If the boolean animator parameter is currently equal to true AND the CropSprite animator's image sprite is the TurnipCropSprite then the following indented code will be executed.
			CropSprite.SetBool ("CropFinished", false);
			// ^ The boolean animator parameter "CropFinished" is set equal to false again so the animator's conditions can be met to move onto the next animation stage.

			if (InventorySlot1Image.sprite == NothingImage) {
				InventorySlot1Image.sprite = TurnipCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else	if (InventorySlot2Image.sprite == NothingImage) {
				InventorySlot2Image.sprite = TurnipCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else	if (InventorySlot3Image.sprite == NothingImage) {
				InventorySlot3Image.sprite = TurnipCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else 	if (InventorySlot4Image.sprite == NothingImage) {
				InventorySlot4Image.sprite = TurnipCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else  if (InventorySlot5Image.sprite == NothingImage) {
				InventorySlot5Image.sprite = TurnipCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else 	if (InventorySlot6Image.sprite == NothingImage) {
				InventorySlot6Image.sprite = TurnipCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} 
			// ^ These statements check that if one of the user's turned on inventory space is "empty" (if its image value is the same as the defined "Nothing Image") that it will be set to the TurnipCropSprite, their EXPLEVEL will increase by 100 -
			// -and the boolean animator parameter "CropTaken" is set equal to false again so the animator's conditions can be met to move onto the next animation stage.
		}

		/// PUMPKIN HARVEST ///
		if ((CropSprite.GetBool("CropFinished") == true) && (CropSprite.GetComponent<Image>().sprite == PumpkinCropSprite)) {
			CropSprite.SetBool ("CropFinished", false);

			if (InventorySlot1Image.sprite == NothingImage) {
				InventorySlot1Image.sprite = PumpkinCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else	if (InventorySlot2Image.sprite == NothingImage) {
				InventorySlot2Image.sprite = PumpkinCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else	if (InventorySlot3Image.sprite == NothingImage) {
				InventorySlot3Image.sprite = PumpkinCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else 	if (InventorySlot4Image.sprite == NothingImage) {
				InventorySlot4Image.sprite = PumpkinCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else  if (InventorySlot5Image.sprite == NothingImage) {
				InventorySlot5Image.sprite = PumpkinCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else 	if (InventorySlot6Image.sprite == NothingImage) {
				InventorySlot6Image.sprite = PumpkinCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} 
		}
		// ^ Does the same as the "TURNIP HARVEST" conditions but for the PumpkinCropSprite.
 
		/// NEEBLE HARVEST ///
		if ((CropSprite.GetBool("CropFinished") == true) && (CropSprite.GetBool("GameDemoOver") == true)) {
			CropSprite.SetBool ("CropFinished", false);

			if (InventorySlot1Image.sprite == NothingImage) {
				InventorySlot1Image.sprite = NeebleCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else	if (InventorySlot2Image.sprite == NothingImage) {
				InventorySlot2Image.sprite = NeebleCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else	if (InventorySlot3Image.sprite == NothingImage) {
				InventorySlot3Image.sprite = NeebleCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else 	if (InventorySlot4Image.sprite == NothingImage) {
				InventorySlot4Image.sprite = NeebleCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else  if (InventorySlot5Image.sprite == NothingImage) {
				InventorySlot5Image.sprite = NeebleCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} else 	if (InventorySlot6Image.sprite == NothingImage) {
				InventorySlot6Image.sprite = NeebleCropSprite;
				EXPLEVEL = EXPLEVEL + 100;
				CropSprite.SetBool ("CropTaken", true);
			} 
			// ^ Does the same as the "TURNIP HARVEST" conditions but for the NeebleCropSprite, however, the first condition isn't that the CropFinished animator parameter must be true but that the boolean animator parameter "GameDemoOver" must be true.

			EndDemoPanel.active = true;
			// ^ If the user clicks plantbox when the boolean animator parameter "GameDemoOver" is true, the EndDemoPanel is set active or visable.
		}
	}
}

