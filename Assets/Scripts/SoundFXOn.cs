using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class SoundFXOn : MonoBehaviour {
	// ^ Declares that the indented code is part of the "SoundFXOn" class. 

	public Toggle SoundFXCheckbox;
	public AudioSource ButtonClickFX;
	public AudioSource TradeBuyAndSellFX;
	public AudioSource PlantBoxClick;
	// ^ Declaring all the game objects and variables this script will be using. (In the editor mode I will have dragged the objects these refer to from the hierarchy into the script via the inspector).

	void Update () {
	// ^ When this object first becomes active or "Starts" the indented code will be iterated repeatedly at regular intervals.
		if (SoundFXCheckbox.isOn) {
			ButtonClickFX.volume = 1;
			TradeBuyAndSellFX.volume = 1;
			PlantBoxClick.volume = 1;
			// ^ If the SoundFX toggle on the SettingsPanel is checked or on then all the audio sources that make the game sound effects are set to 1 (the highest volume).
		} else {
			ButtonClickFX.volume = 0;
			TradeBuyAndSellFX.volume = 0;
			PlantBoxClick.volume = 0;
			// ^ If the SoundFX toggle on the SettingsPanel is unchecked or off then all the audio sources that make the game sound effects are set to 0.
		}
			
	}

}
