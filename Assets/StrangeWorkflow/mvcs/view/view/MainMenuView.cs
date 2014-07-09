using System.Collections.Generic;
using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

public class MainMenuView : View
{
		
	public Signal loadMessageClickSignal;

	public MainMenuView()
	{
		//Debug.Log ("CustomViewUI.constructor()");
		loadMessageClickSignal	 = new Signal();

	}

	override protected void Start ()
	{
			//
			base.Start ();
			Debug.Log("Main View Start");
			loadMessageClickSignal.Dispatch();
	}
}	