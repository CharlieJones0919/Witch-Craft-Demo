using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class MusicVolume : MonoBehaviour {
	// ^ Declares that the indented code is part of the "MusicVolume" class. 

	public Slider Volume;
	public AudioSource MenuMusic;
	// ^ Declaring all the game objects and variables this script will be using. (In the editor mode I will have dragged the objects these refer to from the hierarchy into the script via the inspector).

	void Update () {
	// ^ When this object first becomes active or "Starts" the indented code will be iterated repeatedly at regular intervals.
		MenuMusic.volume = Volume.value;
		// ^ The volume of the MenuMusic audio source (the audio object playing the game's music file) is equal to the value the Volume slider in the Settings menu is set to.
	}
}