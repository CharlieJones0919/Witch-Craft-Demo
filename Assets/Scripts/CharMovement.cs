using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class CharMovement : MonoBehaviour 
// ^ Declares that the indented code is part of the "CharMovement" class. 
{
	Animator AdelaideMovement;
	// ^ Declares that the indented code is part of the "CharMovement" class. 

	public float MoveSpeed = 3;
	public GameObject TradeMenuScreen;
	public GameObject FrontWall;
	public GameObject Adelaide;
	public float PlayerPositionY;
	public GameObject GardenTravelScreen;
	public Vector3 MoveBack;
	public Button CashRegister;
	// ^ Declaring all the game objects and variables this script will be using. (In the editor mode I will have dragged the objects these refer to from the hierarchy into the script via the inspector).

	public void Start () 
	{
		AdelaideMovement = GetComponent<Animator> ();
	}
	// ^ When this object first becomes active or "Starts", the variable "AdelaideMovement" will be set equal to the animator assigned to it so it can be referenced in this script.

	void Update () 
	// ^ When this object first becomes active or "Starts" the indented code will be iterated repeatedly at regular intervals.
	{
		PlayerPositionY = Adelaide.transform.position.y;
		// Saves the player object sprite's co-oridnate on the Y-axis to the variable "PlayerPositionY".

		if (TradeMenuScreen.active == true || GardenTravelScreen.active == true) {
			MoveSpeed = 0;
			// ^ If the TradeMenu OR GardenTravelScreens are showing then the character sprite this script is attatched to won't be able to move as their speed is set to 0.
		} else if (PlayerPositionY < -3.2) {
			MoveSpeed = 0;
			// ^ If the condition from the last statement isn't true but the player's position is less than -3.2 (about the placement of the doorway), then the player won't be able to move either.
			Adelaide.transform.position = MoveBack;
			GardenTravelScreen.active = true;
			// ^ Line 41 sets the character sprite's position on the game screen to the value of the Vector3 "MoveBack" which is assigned in the inspector as with a Y-axis value of more than -3.2 so this statement won't remain true.
			// This is required otherwise line 42 would always be run and the user wouldn't be able to close the "GardenTravelScreen" panel.
		} else {
			MoveSpeed = 3;
			CharacterMovement();
			// ^ If the above statements aren't true then the sprite's speed will be set to 3 so they can move and the CharacterMovement method will be run.
		}

		if (GardenTravelScreen.active == true) {
			CashRegister.interactable = false;
		} else {
			CashRegister.interactable = true;
		}
		// ^ This makes it so the user can't open the TradeMenu while the other GardenTravelScreen is already active.

		if (PlayerPositionY < -1.5) {
			FrontWall.active = true;
		} else {
			FrontWall.active = false;
		}
		// ^ If the character sprite's position is less than -1.5 the FrontWall image will appear to show the user where they can walk.
	}

	void CharacterMovement() {
		// ^ Declares that the indented code will be run if this method is called.

		///// MOVING LEFT CONTROLS AND ANIMATION /////
		if (Input.GetAxisRaw("Horizontal") < 0f) {
			// ^ Unity has names for move input devices and any input that would ususally be for moving horizontally has already been named "Horizontal". So this would include the "A" and "D" keys on a keyboard, the left -
			// -and right arrow keys on a keyboard, and pushing left or right on a joystick. If this value is less than 0 (left on the X-axis) then the following code will be run.
			transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * MoveSpeed * Time.deltaTime, 0f, 0f));
			// ^ The object this is attached to's position on the X-axis of it's Vector3 will be set equal to its own value multiplied by the MoveSpeed (3) and time (so it's consistant on all devices regardless of framerate).
			AdelaideMovement.SetBool("MovingLeft", true);
			// ^ The sprite's animator "AdelaideMovement" will transfer to its "MovingLeft" state or animation.
		} else {
			AdelaideMovement.SetBool("MovingLeft", false);
			// ^ If the above is false then the animator will return to its default animation: the Stationary.
		}
			
		///// MOVING RIGHT CONTROLS AND ANIMATION /////
		if (Input.GetAxisRaw("Horizontal") > 0f) {
			transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * MoveSpeed * Time.deltaTime, 0f, 0f));
			AdelaideMovement.SetBool("MovingRight", true);
		} else {
			AdelaideMovement.SetBool("MovingRight", false);
		}

		///// MOVING BACK CONTROLS AND ANIMATION /////
		if (Input.GetAxisRaw("Vertical") > 0f)
		{
			transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * MoveSpeed * Time.deltaTime, 0f));
			AdelaideMovement.SetBool("MovingBack", true);
		} else {
			AdelaideMovement.SetBool("MovingBack", false);
		}

		///// MOVING FORWARD CONTROLS AND ANIMATION /////
		if (Input.GetAxisRaw("Vertical") < 0f)
		{
			transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * MoveSpeed * Time.deltaTime, 0f));
			AdelaideMovement.SetBool("MovingForward", true);
		} else {
			AdelaideMovement.SetBool("MovingForward", false);
		}

		// ^ Exactly the same as the "MOVING LEFT CONTROLS AND ANIMATION" but for right, back and forwards movement input.
	}
}