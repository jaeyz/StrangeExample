using System.Collections.Generic;
using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

public class MainMenuView : View
{
		
	public Signal mainMenuLoadedSignal;

	public MainMenuView()
	{
		mainMenuLoadedSignal = new Signal();
	}

	override protected void Start ()
	{
			base.Start ();
			Debug.Log("Main View Start");
			mainMenuLoadedSignal.Dispatch();
	}
}	