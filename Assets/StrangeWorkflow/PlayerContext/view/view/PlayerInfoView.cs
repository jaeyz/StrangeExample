using System.Collections.Generic;
using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

public class PlayerInfoView : View
{
		
	public Signal playerInfoLoaded;
	public Signal goToMainMenuClicked;

	public string playerName;
	public PlayerInfoView()
	{
		playerInfoLoaded = new Signal();
		goToMainMenuClicked = new Signal();
	}

	override protected void Start ()
	{
			base.Start ();
			playerInfoLoaded.Dispatch();
	}

	void OnGUI () {
		GUI.Box(new Rect(150,50,200,200), "Welcome " + playerName );

		if(GUI.Button(new Rect(170,80,150,20), "Login")) {
			NGUIDebug.Log("Loading Main Menu");
		    goToMainMenuClicked.Dispatch();
		}
		    
		if(GUI.Button(new Rect(170,100,150,20), "Register")) {
		}
			
		if(GUI.Button(new Rect(170,130,150,20), "Quit")) {
		}
	}
}	