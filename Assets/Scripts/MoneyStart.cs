using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class MoneyStart : MonoBehaviour {
	// ^ Declares that the indented code is part of the "MoneyStart" class. 

	public static float MoneyValue;
	public Text MoneyValueText;

	// ^ Declaring all the game objects and variables this script will be using. (In the editor mode I will have dragged the objects these refer to from the hierarchy into the script via the inspector).

	public void Start () {
		MoneyValue = 200f;
	}
	// ^ When this object first becomes active or "Starts", the float variable "MoneyValue" will be set equal to 200 so the user can buy their initial items they require.

	public void Update () {
	// ^ When this object first becomes active or "Starts" the indented code will be iterated repeatedly at regular intervals.
		MoneyValueText.text = MoneyValue.ToString();
		// ^ The MoneyValue text game object is repeatedly being set equal to the float variable "MoneyValue" as a string meaning the text aspect changes as soon as the float aspect changes so the user always - 
		// -knows how much money they have.
	}
}
