using UnityEngine;
using System.Collections;
// ^ Importing the Unity engine features or mechanics this script will require. 

public class QuitOnClick : MonoBehaviour {
	// ^ Declares that the indented code is part of the "QuitOnClick" class. This is attached to the Quit button on the MenuPanel. 

	public void Quit()
	// ^ The indented code is the Quit() method.
	{
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		// ^ If the game is currently running in the Unity Editor playmode the game will just stop playing when this method is called.
		#else
			Application.Quit ();
		// ^ If the game isn't currently running in the Unity Editor playmode (so it's a build version), the application will be quit when this method is called.
		#endif
	}
}