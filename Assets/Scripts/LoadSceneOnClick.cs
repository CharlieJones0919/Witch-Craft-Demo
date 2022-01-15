using UnityEngine;
using System.Collections;
using UnityEngine.UI;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class LoadSceneOnClick : MonoBehaviour {
	// ^ Declares that the indented code is part of the "LoadSceneOnClick" class. This is attached to the "Start Game" button on the InputName panel. (The game orginially had two seperate scenes for the menu screen and the -
	// -gameplay screens and this button used to load the scene in when clicked through the scene index but I realised it would be easier to make them part of the same scene in terms of editing and would make the transition smoother. -
	// -That's why it's called "LoadSceneOnClick" despite not loading any scenes or being triggered when an object is clicked.

	public InputField NameTextbox;
	public Button StartGameButton;
	// ^ Declaring all the game objects and variables this script will be using. (In the editor mode I will have dragged the objects these refer to from the hierarchy into the script via the inspector).

	void Update () {
		// ^ When this object first becomes active or "Starts" the indented code will be iterated repeatedly at regular intervals.
		if (NameTextbox.text != "") {
			StartGameButton.interactable = true;
		} else {
			StartGameButton.interactable = false;
		}
		// ^ If the text in the NameTextbox object doesn't equal nothing then the user can interact with the StartGameButton, if not it's disabled.
	}

}